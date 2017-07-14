using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/************************2017/7/14*****************************
 * 
 * Base.Program
 * 功能：主函数入口
 * 主要接口：-
 * 注意事项：-
 * 
 *************************************************************/

namespace PEP
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            if (formLogin.DialogResult == DialogResult.OK) //用以判断是否登录成功
            {
                formLogin.Close();
                Application.Run(new FormUser(formLogin.getUsername()));
            }
        }
    }
}
