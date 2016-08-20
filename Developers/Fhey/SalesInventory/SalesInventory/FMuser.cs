using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SalesInventory
{
    class FMuser
    {
        private MySqlCommand cmd;
        private MySqlDataReader read;
        StructUser user = new StructUser();


        public void Retrieve (string id)
        {
            StructUser user = new StructUser();
            if (!Connection.IsOpen)
                Connection.Open();
            string select = string.Format("SELECT * FROM tbluser where userid='{0}' ", id);
            cmd = new MySqlCommand(select, Connection.MySqlConnection);
            read = cmd.ExecuteReader();
            if(read.HasRows)
                while(read.Read())
                {
                    user.USERID = read.GetValue(0).ToString();
                    user.PASSWORD = read.GetValue(1).ToString();
                    user.FIRSTNAME = read.GetValue(2).ToString();
                    user.MIDDLENAME = read.GetValue(3).ToString();
                    user.LASTNAME = read.GetValue(4).ToString();
                    user.POSITION = read.GetValue(5).ToString();
                }
            user.USERID = id;
            Connection.Close();
            //return user;

        }
        public void Update (StructUser user)
        {
           // if (Connection.IsOpen)
                Connection.Open();
                string update = string.Format("UPDATE tbluser SET password='{1}',  firstname='{2}',    middlename='{3}',   lastname='{4}', position='{5}' WHERE userID='{0}'  ",
                    user.USERID, user.PASSWORD, user.FIRSTNAME, user.MIDDLENAME, user.LASTNAME, user.POSITION);
                cmd = new MySqlCommand(update, Connection.MySqlConnection);
                read = cmd.ExecuteReader();
            MessageBox.Show("Saved!");

            Connection.Close();
        }
        
        public void Add(StructUser user)
        {
            Connection.Open();
            string insert = string.Format("INSERT tbluser SET userID ='{0}', password='{1}', firstname = '{2}', middlename = '{3}', lastname = '{4}', position = '{5}'",
                user.USERID, user.PASSWORD, user.FIRSTNAME, user.MIDDLENAME, user.LASTNAME, user.POSITION);
            cmd = new MySqlCommand(insert, Connection.MySqlConnection);
            read = cmd.ExecuteReader();
            MessageBox.Show("Saved!");

            Connection.Close();
        }

    }
}
