using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace _08.Baza_Podataka_ADP_ZID
{
    class Kripcija
    {
        public Kripcija(){}

        private string Key = "alkjepaismnbmxcvjqwepqirpy92831a"; // 32 karaktera
        private string IV = "jh98yf39hfibwede"; // 16 karaktera

        public string kodiraj(string unos){
            byte[] bitoviUnosa;
            try {bitoviUnosa = System.Text.ASCIIEncoding.ASCII.GetBytes(unos); }
            catch(Exception){return ""; }

            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Key = System.Text.ASCIIEncoding.ASCII.GetBytes(Key);
            aes.IV = System.Text.ASCIIEncoding.ASCII.GetBytes(IV);
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;
            ICryptoTransform kripto = aes.CreateEncryptor(aes.Key, aes.IV);
            byte[] kod = kripto.TransformFinalBlock(bitoviUnosa, 0, bitoviUnosa.Length);
            kripto.Dispose();
            return Convert.ToBase64String(kod);
        }

        public string dekodiraj(string unos){
            byte[] kriptovaniBiti;
            try { kriptovaniBiti = Convert.FromBase64String(unos); }
            catch(Exception) { return ""; }

            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Key = System.Text.ASCIIEncoding.ASCII.GetBytes(Key);
            aes.IV = System.Text.ASCIIEncoding.ASCII.GetBytes(IV);
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;
            ICryptoTransform kripto = aes.CreateDecryptor(aes.Key, aes.IV);
            byte[] dekodiraniBiti = kripto.TransformFinalBlock(kriptovaniBiti, 0, kriptovaniBiti.Length);
            return System.Text.ASCIIEncoding.ASCII.GetString(dekodiraniBiti);
        }
    }
}
