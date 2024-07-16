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
        public static void DirectoryStartControl()
        {
            if (!Directory.Exists(DicInfo.savedPath))
            {
                Directory.CreateDirectory(DicInfo.savedPath);
            }
        }
        public static void CreateStickyFile(string title)
        {
            int id = Convert.ToInt32(DataOperations.LastDateId());
            string stextPath = DicInfo.savedPath + "\\" + DicInfo.savedPathFileName + (id + 1) + ".stxt";
            var createdFile = File.Create(stextPath);

            if (File.Exists(stextPath))
                DataOperations.NewData(stextPath, title, DateTime.Now.ToString());
            createdFile.Close();
            File.WriteAllText(stextPath, StickyTextOperations.DefaultValue());
        }
        public static bool isFileThere(string path)
        {
            return File.Exists(path);
        }
        public static string OpenFileAndLoad(string path)
        {
            if (isFileThere(path))
            {
                return File.ReadAllText(path);
            }
            else
                return "";
        }
        public static void DeleteFile(string path)
        {
            File.Delete(path);
        }
    }
}