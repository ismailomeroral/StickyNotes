using EncryptedNotes.Models;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace EncryptedNotes.ViewModels
{
    internal class Encryption
    {
        /// <Summary>
        /// Verilen düz metni, şifreleme anahtarı kullanarak şifreler ve Base64 string olarak döndürür.
        /// </Summary>
        /// <Returns>
        /// Şifrelenmiş metni Base64 formatında string olarak döndürür.
        /// </Returns>
        /// <param name="plainText">Şifrelenecek düz metin.</param>
        /// <param name="passwordkey">Şifreleme için kullanılacak anahtar.</param>
        public static string Encrypted(string plainText, string passwordkey)
        {
            byte[] encrypted = Encrypt(plainText, passwordkey);
            string result = Convert.ToBase64String(encrypted);
            return result;
        }

        /// <Summary>
        /// Verilen şifreli metni, şifreleme anahtarı kullanarak çözümleyip düz metin olarak döndürür.
        /// </Summary>
        /// <Returns>
        /// Çözülmüş metni string olarak döndürür. Eğer hata oluşursa boş string döner.
        /// </Returns>
        /// <param name="cipherText">Çözülecek şifreli metin (Base64 formatında).</param>
        /// <param name="passwordkey">Çözümleme için kullanılacak anahtar.</param>
        public static string Decrypted(string cipherText, string passwordkey)
        {
            string result = "";
            try
            {
                byte[] encryptedBytes = Convert.FromBase64String(cipherText);
                result = Decrypt(encryptedBytes, passwordkey);
            }
            catch (Exception e)
            {
            }
            return result;

        }

        /// <Summary>
        /// Verilen düz metni şifreleme anahtarı kullanarak AES ile şifreler ve byte dizisi olarak döndürür.
        /// </Summary>
        /// <Returns>
        /// Şifrelenmiş metni byte dizisi olarak döndürür.
        /// </Returns>
        /// <param name="plainText">Şifrelenecek düz metin.</param>
        /// <param name="passwordkey">Şifreleme için kullanılacak anahtar.</param>
        private static byte[] Encrypt(string plainText, string passwordkey)
        {
            using (var aesAlg = Aes.Create())
            {
                var key = new Rfc2898DeriveBytes(passwordkey, File.ReadAllBytes(DirInfo.saltPath), 10000);
                aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
                aesAlg.IV = key.GetBytes(aesAlg.BlockSize / 8);

                using (var encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV))
                using (var msEncrypt = new MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (var swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }
                    return msEncrypt.ToArray();
                }
            }
        }

        /// <Summary>
        /// Verilen şifreli metni, şifreleme anahtarı kullanarak AES ile çözümler ve düz metin olarak döndürür.
        /// </Summary>
        /// <Returns>
        /// Çözülmüş metni string olarak döndürür.
        /// </Returns>
        /// <param name="cipherText">Çözülecek şifreli metin (byte dizisi olarak).</param>
        /// <param name="passwordkey">Çözümleme için kullanılacak anahtar.</param>
        private static string Decrypt(byte[] cipherText, string passwordkey)
        {
            using (var aesAlg = Aes.Create())
            {
                var key = new Rfc2898DeriveBytes(passwordkey, File.ReadAllBytes(DirInfo.saltPath), 10000);
                aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
                aesAlg.IV = key.GetBytes(aesAlg.BlockSize / 8);

                using (var decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV))
                using (var msDecrypt = new MemoryStream(cipherText))
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (var srDecrypt = new StreamReader(csDecrypt))
                {

                    return srDecrypt.ReadToEnd();
                }
            }
        }
    }
}
