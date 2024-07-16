using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptedNotes.Models
{
    internal class NoteInformation
    {
        public string id { get; set; }
        public string title { get; set; }
        public string path { get; set; }
        public string lastDate { get; set; }
    }
}
