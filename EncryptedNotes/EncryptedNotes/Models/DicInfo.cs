using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptedNotes.Models
{
    static class DicInfo
    {
        static public string savedPath { get; } = "C:\\Users\\" + System.Environment.UserName + "\\StickyNotes";
        static public string savedPathFileName { get; } = "StickyNote";
        static public string xmlPath { get; } = "..\\..\\EntityModels\\Notes.xml";
        static public string saltPath { get; } = "..\\..\\EntityModels\\salt.txt";
    }
}
