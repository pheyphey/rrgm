using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace RRGM
{
    class ClassFMuser
    {
        private MySqlCommand cmd;
        private MySqlDataReader read;
        ClassStructUser _structUser = new ClassStructUser();

        public void Retrieve(string id) 
        {
            
            if (!Connection.IsOpen)
                Connection.Open();
            string select = string.Format("SELECT * FROM tbluser where userid='{0}' ", id);
            cmd = new MySqlCommand(select, Connection.MySqlConnection);
            read = cmd.ExecuteReader();
            if (read.HasRows)
                while (read.Read())
                {
                   _structUser.USERID = read.GetValue(0).ToString();
                   _structUser.PASSWORD = read.GetValue(1).ToString();
                   _structUser.FIRSTNAME = read.GetValue(2).ToString();
                   _structUser.MIDDLENAME = read.GetValue(3).ToString();
                   _structUser.LASTNAME = read.GetValue(4).ToString();
                   _structUser.POSITION = read.GetValue(5).ToString();
                }
            _structUser.USERID = id;
            Connection.Close();
            //return user;

        }
        public void Update(ClassStructUser user)
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

        public void Add(ClassStructUser user)
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
