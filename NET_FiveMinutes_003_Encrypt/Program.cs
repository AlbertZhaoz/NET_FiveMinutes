using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NET_FiveMinutes_003_Encrypt.Common;

namespace NET_FiveMinutes_003_Encrypt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test = "telangpu";
            Console.WriteLine($"原始字符串:{test}");
            string encryptTestMd5 = Md5Encrypt.Encrypt(test);
            Console.WriteLine($"Md5加密的字符串：{encryptTestMd5}");
            string encryptTestDes = DesEncrypt.Encrypt(test);
            Console.WriteLine($"Des加密的字符串：{encryptTestDes}");
            Console.WriteLine($"Des还原的字符串：{DesEncrypt.Decrypt(encryptTestDes)}");
            KeyValuePair<string, string> encryptDecrypt = RsaEncrypt.GetKeyPair();
            string rsaEn1 = RsaEncrypt.Encrypt(test, encryptDecrypt.Key);
            string rsaDe1 = RsaEncrypt.Decrypt(rsaEn1, encryptDecrypt.Value);
            Console.WriteLine($"Rsa加密的字符串：{rsaEn1}");
            Console.WriteLine($"Rsa还原的字符串：{rsaDe1}");
            Console.ReadLine();
        }
    }

    class Student
    {
        public string name;
        public string age;
    }
}
