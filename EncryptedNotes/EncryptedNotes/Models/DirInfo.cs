using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptedNotes.Models
{
    /// <Summary>
    /// Yolu ve dosya adını belirlemek için kullanılan statik sınıf.
    /// </Summary>
    static class DirInfo
    {
        /// <Summary>
        /// Notların kaydedileceği ana dizin yolu.
        /// </Summary>
        static public string savedPath { get; } = "C:\\Users\\" + System.Environment.UserName + "\\StickyNotes";

        /// <Summary>
        /// Not dosyalarının adlarının başlangıcı.
        /// </Summary>
        static public string savedPathFileName { get; } = "StickyNote";

        /// <Summary>
        /// XML dosyasının yolu.
        /// </Summary>
        static public string xmlPath { get; } = "..\\..\\EntityModels\\Notes.xml";

        /// <Summary>
        /// Salt dosyasının yolu.
        /// </Summary>
        static public string saltPath { get; } = "..\\..\\EntityModels\\salt.txt";
    }
}
