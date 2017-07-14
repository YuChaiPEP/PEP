using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

/************************2017/7/14*****************************
 * 
 * Back.PushControl
 * 功能：处理接口层与推送有关的操作
 * 主要接口：next, last, push
 * 注意事项：为推送的删除预留操作。实现next和last接口时，需要首先检查当前id的推送是否存在
 * 
 *************************************************************/

namespace PEP
{
    public class PushControl
    {
        private SQLHandler sql;
        private int min;
        private int max;
        private int current;
        private bool isEmpty;
        public PushControl()
        {
            this.min = this.max = this.current = -1;
            this.isEmpty = false;
            this.sql = new SQLHandler();
            this.sql.SQLConnect();
            MySqlDataReader dr1 = this.sql.SQLGet("fid", "pushs", "1=1 order by fid"); //当判断条件不需要时可以使用永真语句true或者1=1
            if (!dr1.Read())
            {
                this.isEmpty = true;
                dr1.Close();
                return;
            }
            else
            {
                this.min = (int)dr1["fid"];
                dr1.Close();
                MySqlDataReader dr2 = this.sql.SQLGet("fid", "pushs", "1=1 order by fid desc"); //降序排列
                dr2.Read();
                this.max = (int)dr2["fid"];
                dr2.Close();
                this.current = this.min;
            }
        }
        public MySqlDataReader getInitialText()
        {
            return getPushReader();
        }
        public MySqlDataReader getNextPush()
        {
            if (this.isEmpty)
                getPushReader();
            moveForward();
            while (!this.sql.SQLQuery("pushs", "fid="+this.current)) //不存在时跳过
            {
                moveForward();
            }
            return getPushReader();
        }
        public MySqlDataReader getLastPush()
        {
            if (this.isEmpty)
                getPushReader();
            moveBackward();
            while (!this.sql.SQLQuery("pushs", "fid=" + this.current))
            {
                moveBackward();
            }
            return getPushReader();
        }
        public void pushSubmit(String push, String time, int uid)
        {
            this.sql.SQLInsertOneEntry("pushs(uid,timestamp,push)", "(" + uid + ",'"+time+"','"+push+"')");
        }
        private MySqlDataReader getPushReader()
        {
            return this.sql.SQLGet("*", "pushs", "fid=" + this.current);
        }
        private void moveForward()
        {
            //循环递增
            if (this.current < this.max)
                this.current++;
            else
                this.current = this.min;
        }
        private void moveBackward()
        {
            //循环递减
            if (this.current > this.min)
                this.current--;
            else
                this.current = this.max;
        }
        ~PushControl()
        {
            this.sql.SQLDisconnect();
        }
    }
}
