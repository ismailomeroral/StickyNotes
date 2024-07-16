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
        private static Dictionary<string, string> tagPatterns = new Dictionary<string, string>
        {
            {"Title", "<Title>(.*?)</Title>"},
            {"Key", "<Key>(.*?)</Key>"},
            {"Visibility", "<Visibility>(.*?)</Visibility>"},
            {"Password", "<Password>(.*?)</Password>"},
            {"Body", "<Body>(.*?)</Body>"},
            {"Color", "<Color>(.*?)</Color>"}
        };
        private static List<PatternInformation> defaultValues = new List<PatternInformation>
        {
            new PatternInformation{key = "Color", value = "Gold"},
            new PatternInformation{key = "Visibility", value = "false"},
            new PatternInformation{key = "Title", value = ""},
            new PatternInformation{key = "Body", value = ""},
            new PatternInformation{key = "Key", value = ""},
            new PatternInformation{key = "Password", value = ""},
        };
        static public string DefaultValue()
        {
            string sText = "";
            foreach (var item in tagPatterns)
            {
                sText += $"<{item.Key}>{defaultValues.Where(b => b.key == item.Key).First().value}</{item.Key}> \n";
            }
            return "";
        }
        static private void ProcessContent(string path, List<PatternInformation> piecesofcontent)
        {
            string content = "";
            foreach (PatternInformation item in piecesofcontent)
                content += $"<{item.key}>{item.value}</{item.key}> \n ";
            File.WriteAllText(path, content);
        }
        static public List<PatternInformation> SendPattern(string values)
        {
            List<PatternInformation> list = BreakUPText(values);
            foreach (PatternInformation item in FindMissingPatterns(list))
                list.Add(new PatternInformation { key = item.key, value = item.value });
            return list;
        }
        static public void SaveContext(string key, string content, List<PatternInformation> PatternList, string path)
        {
            List<PatternInformation> list = PatternList.Where(b => b.key == key).ToList();
            if (list.Count > 0)
                list.First().value = content;
            else
                PatternList.Add(CreatePattern(key, content));

            StickyTextOperations.ProcessContent(path, PatternList);

        }
        static private PatternInformation CreatePattern(string key, string Content)
        {
            return new PatternInformation { key = key, value = Content };
        }
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
        static public bool PasswordChecked(string entryPassword, string password)
        {
            bool check = false;
            if (entryPassword == password)
                check = true;
            else
                check = false;

            return check;
        }
        static public bool PasswordControl(string password)
        {
            bool control = false;
            if (password != "")
                control = true;
            else
                control = false;

            return control;
        }
    }
}
