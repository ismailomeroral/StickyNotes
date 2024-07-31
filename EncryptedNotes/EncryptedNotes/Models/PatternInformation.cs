using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptedNotes.Models
{
    /// <Summary>
    /// Bir anahtar-değer çiftini temsil eden sınıf.
    /// </Summary>
    internal class PatternInformation
    {
        /// <Summary>
        /// Anahtar (key) değeri.
        /// </Summary>
        public string key { get; set; }

        /// <Summary>
        /// Değer (value).
        /// </Summary>
        public string value {  get; set; }
    }
}
