using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptedNotes.Models
{

    /// <Summary>
    /// Bir notun bilgilerini temsil eden sınıf.
    /// </Summary>
    internal class NoteInformation
    {
        /// <Summary>
        /// Notun benzersiz kimliği.
        /// </Summary>
        public string id { get; set; }
        /// <Summary>
        /// Notun başlığı.
        /// </Summary>
        public string title { get; set; }

        /// <Summary>
        /// Notun dosya yolu.
        /// </Summary>
        public string path { get; set; }

        /// <Summary>
        /// Notun son güncellenme tarihi.
        /// </Summary>
        public string lastDate { get; set; }
    }
}
