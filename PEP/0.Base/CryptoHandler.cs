using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Globalization;

namespace PEP
{
    class CryptoHandler
    {
        public static string MD5Encrypt(string input)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            var data = Encoding.UTF8.GetBytes(input);
            var encs = md5.ComputeHash(data);
            return BitConverter.ToString(encs).Replace("-", "");
        }
    }
}
