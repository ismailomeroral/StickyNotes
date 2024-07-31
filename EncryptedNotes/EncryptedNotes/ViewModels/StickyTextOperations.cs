using EncryptedNotes.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptedNotes.ViewModels
{
    internal class StickyTextOperations
    {
        /// <Summary>
        /// Tag ve Regex desenleriyle dolu bir dictionary oluşturur.
        /// </Summary>
        private static Dictionary<string, string> tagPatterns = new Dictionary<string, string>
        {
            {"Title", "<Title>(.*?)</Title>"},
            {"Key", "<Key>(.*?)</Key>"},
            {"Visibility", "<Visibility>(.*?)</Visibility>"},
            {"Password", "<Password>(.*?)</Password>"},
            {"Body", "<Body>(.*?)</Body>"},
            {"Color", "<Color>(.*?)</Color>"}
        };
        /// <Summary>
        /// Taglere karşılık gelen varsayılan değerlerin listesini oluşturur.
        /// </Summary>
        private static List<PatternInformation> defaultValues = new List<PatternInformation>
        {
            new PatternInformation{key = "Color", value = "Gold"},
            new PatternInformation{key = "Visibility", value = "false"},
            new PatternInformation{key = "Title", value = ""},
            new PatternInformation{key = "Body", value = ""},
            new PatternInformation{key = "Key", value = ""},
            new PatternInformation{key = "Password", value = ""},
        };
        /// <Summary>
        /// Varsayılan XML benzeri metni oluşturur.
        /// </Summary>
        /// <Returns>
        /// Varsayılan değerlerle dolu bir XML formatında string döndürür.
        /// </Returns>
        static public string DefaultValue()
        {
            string sText = "";
            foreach (var item in tagPatterns)
            {
                sText += $"<{item.Key}>{defaultValues.Where(b => b.key == item.Key).First().value}</{item.Key}> \n";
            }
            return "";
        }

        /// <Summary>
        /// Verilen içerik parçalarını birleştirir ve belirtilen yola yazar.
        /// </Summary>
        /// <param name="path">İçeriğin yazılacağı dosya yolu.</param>
        /// <param name="piecesofcontent">İçerik parçalarını içeren liste.</param>
        static private void ProcessContent(string path, List<PatternInformation> piecesofcontent)
        {
            string content = "";
            foreach (PatternInformation item in piecesofcontent)

                content += $"<{item.key}>{item.value}</{item.key}> \n ";
            File.WriteAllText(path, content);
        }

        /// <Summary>
        /// Verilen metni parçalayarak bir liste haline getirir ve eksik olan tagleri varsayılan değerlerle tamamlar.
        /// </Summary>
        /// <Returns>
        /// Eksik taglerin varsayılan değerlerle tamamlandığı PatternInformation listesi döndürür.
        /// </Returns>
        /// <param name="values">Parçalanacak XML benzeri metin.</param>
        static public List<PatternInformation> ReturnPattern(string values)
        {
            List<PatternInformation> list = BreakUPText(values);
            foreach (PatternInformation item in FindMissingPatterns(list))
                list.Add(new PatternInformation { key = item.key, value = item.value });

            return list;
        }
        /// <Summary>
        /// Verilen anahtar ve içerik değerlerini kaydeder, listeyi günceller ve dosyaya yazar.
        /// </Summary>
        /// <param name="key">Güncellenecek veya eklenecek tagin anahtarı.</param>
        /// <param name="content">Kaydedilecek içerik.</param>
        /// <param name="PatternList">Mevcut PatternInformation listesini içerir.</param>
        /// <param name="path">İçeriğin yazılacağı dosya yolu.</param>
        static public void SaveContext(string key, string content, List<PatternInformation> PatternList, string path)
        {
            List<PatternInformation> list = PatternList.Where(b => b.key == key).ToList();
            if (list.Count > 0)
                list.First().value = content;
            else
                PatternList.Add(CreatePattern(key, content));

            ProcessContent(path, PatternList);
        }
        /// <Summary>
        /// Yeni bir PatternInformation nesnesi oluşturur.
        /// </Summary>
        /// <Returns>
        /// Oluşturulan PatternInformation nesnesini döndürür.
        /// </Returns>
        /// <param name="key">Oluşturulacak PatternInformation'ın anahtarı.</param>
        /// <param name="Content">Oluşturulacak PatternInformation'ın değeri.</param>
        static private PatternInformation CreatePattern(string key, string Content)
        {
            return new PatternInformation { key = key, value = Content };
        }
        /// <Summary>
        /// Belirtilen anahtarla eşleşen içeriği liste veya varsayılan değerlerden seçer.
        /// </Summary>
        /// <Returns>
        /// Anahtara karşılık gelen değeri string olarak döndürür.
        /// </Returns>
        /// <param name="key">Seçilecek içeriğin anahtarı.</param>
        /// <param name="PatternList">Mevcut PatternInformation listesini içerir.</param>
        static public string SelectContext(string key, List<PatternInformation> PatternList)
        {
            string value = "";

            List<PatternInformation> list = PatternList.Where(b => b.key == key).ToList();
            if (list.Count > 0)
                value = list.First().value;
            else
                value = defaultValues.Where(b => b.key == key).First().value;

            return value;
        }

        /// <Summary>
        /// Verilen metni parçalar ve PatternInformation listesini oluşturur.
        /// </Summary>
        /// <Returns>
        /// Parçalanmış verilerden oluşan PatternInformation listesi döndürür.
        /// </Returns>
        /// <param name="values">Parçalanacak XML benzeri metin.</param>
        static private List<PatternInformation> BreakUPText(string values)
        {
            List<PatternInformation> list = new List<PatternInformation>();
            list.Clear();
            foreach (var tag in tagPatterns)
            {
                var matches = Regex.Matches(values, tag.Value, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                foreach (Match match in matches)
                {
                    list.Add(new PatternInformation { key = tag.Key, value = match.Groups[1].Value });
                }
            }
            return list;
        }
        /// <Summary>
        /// Eksik olan tagleri varsayılan değerlerle tamamlar.
        /// </Summary>
        /// <Returns>
        /// Eksik tagleri içeren PatternInformation listesi döndürür.
        /// </Returns>
        /// <param name="list">Eksik taglerin tamamlanacağı PatternInformation listesi.</param>
        static private List<PatternInformation> FindMissingPatterns(List<PatternInformation> list)
        {
            List<PatternInformation> missingPatterns = new List<PatternInformation>();

            foreach (var kvp in tagPatterns)
            {
                bool found = false;
                foreach (var item in list)
                {
                    if (item.key == kvp.Key)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    missingPatterns.Add(new PatternInformation { key = kvp.Key, value = defaultValues.Where(b => b.key == kvp.Key).First().value });
                }
            }

            return missingPatterns;
        }
        /// <Summary>
        /// Girilen şifrenin doğru olup olmadığını kontrol eder.
        /// </Summary>
        /// <Returns>
        /// Eğer şifre doğruysa true, yanlışsa false döndürür.
        /// </Returns>
        /// <param name="entryPassword">Girilen şifre.</param>
        /// <param name="password">Doğrulanacak şifre.</param>
        static public bool CheckPassword(string entryPassword, string password)
        {
            return (entryPassword == password);
        }
        /// <Summary>
        /// Şifrenin boş olup olmadığını kontrol eder.
        /// </Summary>
        /// <Returns>
        /// Eğer şifre boş değilse true, boşsa false döndürür.
        /// </Returns>
        /// <param name="password">Kontrol edilecek şifre.</param
        static public bool ControlPassword(string password)
        {
            return password != "";
        }
    }
}
