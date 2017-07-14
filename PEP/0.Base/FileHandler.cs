using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

/************************2017/7/14*****************************
 * 
 * Base.FileHandler
 * 功能：处理底层与文件相关的读写操作
 * 主要接口：save, read
 * 注意事项：read时若读取失败，返回字符串为空
 * 
 *************************************************************/

namespace PEP
{
    class FileHandler
    {
        public static void fileSave(String address, String filename, String content, bool hidden = false)
        {
            //address末尾应以\结尾
            string path = address + filename;
            if (File.Exists(path))
            {
                File.SetAttributes(path, FileAttributes.Normal);
            }
            FileStream fs = new FileStream(path, FileMode.Create);
            byte[] data = new UTF8Encoding().GetBytes(content);
            fs.Write(data, 0, data.Length);
            fs.Close();
            if (hidden)
            {
                File.SetAttributes(path, FileAttributes.Hidden);
            }
        }

        public static String fileRead(String address, String filename)
        {
            //若路径或文件错误，返回值为空，调用者需判断
            string content = null;
            string path = address + filename;
            if (File.Exists(path))
            {
                FileAttributes attributes = File.GetAttributes(path);
                File.SetAttributes(path, FileAttributes.Normal);
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
                content = sr.ReadToEnd();
                sr.Close();
                File.SetAttributes(path, attributes);
            }
            return content;
        }
    }
}
