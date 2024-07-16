using EncryptedNotes.Models;
using System;
using System.IO;
using System.Security.Cryptography;

namespace EncryptedNotes.ViewModels
{
    internal class Encryption
    {
        public static string Encrypted(string plainText, string passwordkey)
        {
            byte[] encrypted = Encrypt(plainText, passwordkey);
            string result = Convert.ToBase64String(encrypted);
            return result;
        }
        public static string Decrypted(string cipherText, string passwordkey)
        {
            byte[] encryptedBytes = Convert.FromBase64String(cipherText);
            string result = Decrypt(encryptedBytes, passwordkey);
            return result;
        }

        private static byte[] Encrypt(string plainText, string passwordkey)
        {
            using (var aesAlg = Aes.Create())
            {
                var key = new Rfc2898DeriveBytes(passwordkey, File.ReadAllBytes(DicInfo.saltPath), 10000);
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

        private static string Decrypt(byte[] cipherText, string passwordkey)
        {
            using (var aesAlg = Aes.Create())
            {
                var key = new Rfc2898DeriveBytes(passwordkey, File.ReadAllBytes(DicInfo.saltPath), 10000);
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
