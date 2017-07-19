using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

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
            //loadData();
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

        private static void loadData()
        {
            Loader load = new Loader();
            String addr = "D:\\PEP\\PEP\\Resources\\";
            //load.loadUser("D:\\PEP\\PEP\\Resources\\", "用户统计.txt");
            //load.loadPush("D:\\PEP\\PEP\\Resources\\", "PEP推送.txt");
            //load.loadProject("D:\\PEP\\PEP\\Resources\\", "PEP项目信息.txt");
            //load.loadTask("D:\\PEP\\PEP\\Resources\\", "PEP项目流程.txt");
            //load.loadProjectTask("D:\\PEP\\PEP\\Resources\\", "PEP项目流程.txt");
            //load.loadUserProject("D:\\PEP\\PEP\\Resources\\", "用户统计.txt");
        }
    }
}
