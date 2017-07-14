using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/************************2017/7/14*****************************
 * 
 * Back.Login
 * 功能：处理接口层与登录相关的操作
 * 主要接口：authenticate
 * 注意事项：身份认证时密码用MD5进行hash后查询
 * 
 *************************************************************/

namespace PEP
{
    public class Login
    {
        private SQLHandler sql;
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
    }
}
