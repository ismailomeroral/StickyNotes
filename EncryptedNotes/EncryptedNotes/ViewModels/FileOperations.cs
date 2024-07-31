using EncryptedNotes.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptedNotes.ViewModels
{
    internal static class FileOperation
    {
        /// <Summary>
        /// Uygulama dizinini kontrol eder ve eğer mevcut değilse oluşturur.
        /// </Summary>
        public static void DirectoryStartControl()
        {
            if (!Directory.Exists(DirInfo.savedPath))
            {
                Directory.CreateDirectory(DirInfo.savedPath);
            }
        }

        /// <Summary>
        /// Yeni bir yapışkan not dosyası oluşturur ve gerekli verileri kaydeder.
        /// </Summary>
        /// <param name="title">Oluşturulacak dosyanın başlığı.</param>
        public static void CreateStickyFile(string title)
        {
            int id = Convert.ToInt32(DataOperations.LastDateId());
            string stextPath = DirInfo.savedPath + "\\" + DirInfo.savedPathFileName + (id + 1) + ".stxt";
            var createdFile = File.Create(stextPath);

            if (File.Exists(stextPath))
                DataOperations.NewData(stextPath, title, DateTime.Now.ToString());
            createdFile.Close();
            File.WriteAllText(stextPath, StickyTextOperations.DefaultValue());
        }

        /// <Summary>
        /// Belirtilen dosya yolunda dosyanın var olup olmadığını kontrol eder.
        /// </Summary>
        /// <Returns>
        /// Eğer dosya mevcutsa true, değilse false döndürür.
        /// </Returns>
        /// <param name="path">Kontrol edilecek dosya yolu.</param>
        public static bool isFileThere(string path)
        {
            return File.Exists(path);
        }

        /// <Summary>
        /// Belirtilen dosyayı açar ve içeriğini okur.
        /// </Summary>
        /// <Returns>
        /// Dosyanın içeriğini döndürür. Eğer dosya yoksa boş bir string döner.
        /// </Returns>
        /// <param name="path">Açılacak dosyanın yolu.</param>
        public static string OpenFileAndLoad(string path)
        {
            if (isFileThere(path))
            {
                return File.ReadAllText(path);
            }
            else
                return "";
        }

        /// <Summary>
        /// Belirtilen dosyayı siler.
        /// </Summary>
        /// <param name="path">Silinecek dosyanın yolu.</param>
        public static void DeleteFile(string path)
        {
            File.Delete(path);
        }
    }
}