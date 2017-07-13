using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PEP
{
    class FileHandler
    {
        public static void fileSave(String address, String filename, String content, bool hidden = false)
        {
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
