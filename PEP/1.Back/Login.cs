using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/************************2017/7/14*****************************
 * 
 * Back.Login
 * 功能：处理接口层与登录相关的操作，涉及保存密码的本地文件操作
 * 主要接口：authenticate, save, read
 * 注意事项：身份认证时密码用MD5进行hash后查询
 *           包含本地保存密码用的文件与密钥，密钥长度为8位字符串
 * 
 *************************************************************/

namespace PEP
{
    public class Login
    {
        private SQLHandler sql;
        private const string SaveFileName = @"login.ini";
        private const string Key = @"PEP12345";
        public Login()
        {
            sql = new SQLHandler();
            sql.SQLConnect();
        }
        ~Login()
        {
            sql.SQLDisconnect();
        }
        public bool identifyAuthentication(String u, String p)
        {
            bool result = sql.SQLQuery("users", "uname='" + u + "' and password='" + CryptoHandler.MD5Encrypt(p) + "'");
            sql.SQLDisconnect();
            return result;
        }

        public void saveInfo(string dir, bool save, string username, string password)
        {
            string content = "";
            if (save)
            {
                if (username.Length > 0 && password.Length > 0)
                {
                    content = "yes\n";
                    content += (username + "\n");
                    bool success = true;
                    string cryptoPwd = CryptoHandler.DESEncrypt(password, Key, ref success);
                    if (success)
                    {
                        content += cryptoPwd;
                        FileHandler.fileSave(dir, SaveFileName, content, true);
                    }
                }
            }
            else
            {
                content = "no\n.\n.";
                FileHandler.fileSave(dir, SaveFileName, content, true);
            }
        }

        public string[] readInfo(string dir)
        {
            string[] contentArray = null;
            string content = FileHandler.fileRead(dir, SaveFileName);
            if (content != null)
            {
                contentArray = content.Split('\n');
                if (contentArray.Length == 3 && contentArray[0] == "yes")
                {
                    bool success = true;
                    string pwd = CryptoHandler.DESDecrypt(contentArray[2], Key, ref success);
                    if (success)
                    {
                        contentArray[2] = pwd;
                    }
                    else
                    {
                        contentArray[0] = "no";
                    }
                }
                else
                {
                    contentArray = null;
                }
            }
            return contentArray;
        }
    }
}
