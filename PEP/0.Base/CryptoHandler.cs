using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Globalization;

/************************2017/7/14*****************************
 * 
 * Base.CryptoHandler
 * 功能：处理底层需要加密或hash的操作
 * 主要接口：DES加密, DES解密, MD5
 * 注意事项：DES使用的秘钥为64bit（8位字符），传入参数包含一个bool引用，若加解密失败该bool变量赋值为false，否则为true
 * 
 *************************************************************/

namespace PEP
{
    class CryptoHandler
    {
        public static string MD5Encrypt(string input)
        {
            //MD5验证功能，注意MD5只能加密，无法解密；常用于验证
            MD5 md5 = new MD5CryptoServiceProvider();
            var data = Encoding.UTF8.GetBytes(input);
            var encs = md5.ComputeHash(data);
            return BitConverter.ToString(encs).Replace("-", "");
        }
        public static string DESEncrypt(string input, string key, ref bool success)
        {
            //秘钥长度为8位字符串，若长度不对会报错
            success = true;
            byte[] btKey = Encoding.UTF8.GetBytes(key);
            byte[] btIV = Encoding.UTF8.GetBytes(key);
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            using (MemoryStream ms = new MemoryStream())
            {
                byte[] inData = Encoding.UTF8.GetBytes(input);
                try
                {
                    using (CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(btKey, btIV), CryptoStreamMode.Write))
                    {
                        cs.Write(inData, 0, inData.Length);
                        cs.FlushFinalBlock();
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
                catch
                {
                    success = false;
                    return input;
                }
            }
        }

        public static string DESDecrypt(string input, string key, ref bool success)
        {
            //秘钥长度为8位字符串，若长度不对会报错
            //若加解密秘钥不同，可能导致解密出的字符串不可读，会抛出异常，此时success变量为false
            success = true;
            byte[] btKey = Encoding.UTF8.GetBytes(key);
            byte[] btIV = Encoding.UTF8.GetBytes(key);
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            using (MemoryStream ms = new MemoryStream())
            {
                byte[] inData = Convert.FromBase64String(input);
                try
                {
                    using (CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(btKey, btIV), CryptoStreamMode.Write))
                    {
                        cs.Write(inData, 0, inData.Length);
                        cs.FlushFinalBlock();
                    }
                    return Encoding.UTF8.GetString(ms.ToArray());
                }
                catch
                {
                    success = false;
                    return input;
                }
            }
        }
    }
}
