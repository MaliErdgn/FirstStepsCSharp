using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace FirstSteps
{
    internal class EncryptionDecryption
    {
        public static void encryptionDecryption()
        {
            //byte[] KEY;
            //byte[] IV;

            //var encryptionTripleDes = new TripleDES.Create();

            //KEY = encryptionTripleDes.Key;
            //IV = encryptionTripleDes.IV;
            //Console.WriteLine(string.Join(",", KEY));
            //var encText = "Merhaba Mali";
            //var encCipheredText = Encrypt(encText);
            //Console.WriteLine(encCipheredText);

            //static string Encrypt(string encrypts)
            //{
            //    //Convert input into bytes
            //    var encBuffer = Encoding.UTF8.GetBytes(encrypts);
            //    //create instance of crypto provider
            //    var encryptionTripleDes = new TripleDES.Create()
            //    {
            //        IV = IV,
            //        Key = KEY
            //    };
            //    ICryptoTransform transform = encryptionTripleDes.CreateEncryptor();

            //    var encCipherText = transform.TransformFinalBlock(encBuffer, 0, encBuffer.Length);

            //    return Convert.ToBase64String(encCipherText);

            //}
        }
    }
}
