using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;



namespace SalesInventory
{
    class ClassListView
    {
        private MySqlCommand cmd;
        private MySqlDataReader read;
        private StructUser structuser = new StructUser();
        public void lvwUser(ListView listview)
        {
            //lvwUserList.Items.Clear();
            if (!Connection.IsOpen)
                Connection.Open();
            string select = string.Format("SELECT * from tbluser");
            cmd = new MySqlCommand(select, Connection.MySqlConnection);
            read = cmd.ExecuteReader();
            listview.Items.Clear();
            if (read.HasRows)
            {
                while (read.Read())
                {
                    ListViewItem item = new ListViewItem(read.GetValue(0).ToString());
                    item.SubItems.Add(read.GetValue(1).ToString());
                    item.SubItems.Add(read.GetValue(2).ToString());
                    item.SubItems.Add(read.GetValue(3).ToString());
                    item.SubItems.Add(read.GetValue(4).ToString());
                    item.SubItems.Add(read.GetValue(5).ToString());
                    listview.Items.Add(item);
                   
                }
                
            }
        Connection.Close();
            
        }



        public void lvwItems(ListView listview)
        {
            //lvwUserList.Items.Clear();
            if (!Connection.IsOpen)
                Connection.Open();
            string select = string.Format("SELECT * from tbl_inventory");
            cmd = new MySqlCommand(select, Connection.MySqlConnection);
            read = cmd.ExecuteReader();
            listview.Items.Clear();
            if (read.HasRows)
            {
                while (read.Read())
                {
                    ListViewItem item = new ListViewItem(read.GetValue(0).ToString());
                    item.SubItems.Add(read.GetValue(1).ToString());
                    item.SubItems.Add(read.GetValue(2).ToString());
                    item.SubItems.Add(read.GetValue(3).ToString());
                    item.SubItems.Add(read.GetValue(4).ToString());
                    item.SubItems.Add(read.GetValue(5).ToString());
                    item.SubItems.Add(read.GetValue(6).ToString());
                    item.SubItems.Add(read.GetValue(7).ToString());
                    item.SubItems.Add(read.GetValue(8).ToString());
                    item.SubItems.Add(read.GetValue(9).ToString());
                    item.SubItems.Add(read.GetValue(10).ToString());
                    item.SubItems.Add(read.GetValue(11).ToString());
                    item.SubItems.Add(read.GetValue(12).ToString());
                    listview.Items.Add(item);

                }

            }
            Connection.Close();

        }

        public void lvwTransaction_Items(ListView listview)
        {
            //lvwUserList.Items.Clear();
            if (!Connection.IsOpen)
                Connection.Open();
            string select = string.Format("SELECT * from tbl_inventory");
            cmd = new MySqlCommand(select, Connection.MySqlConnection);
            read = cmd.ExecuteReader();
            listview.Items.Clear();
            if (read.HasRows)
            {
                while (read.Read())
                {
                    ListViewItem item = new ListViewItem(read[0].ToString());
                    item.SubItems.Add(read.GetValue(1).ToString());
                    item.SubItems.Add(read.GetValue(2).ToString());

                    listview.Items.Add(item);

                }

            }
            Connection.Close();

        }

        public void lvwTransaction_Cust(ListView listview)
        {
            //lvwUserList.Items.Clear();
            if (!Connection.IsOpen)
                Connection.Open();
            string select = string.Format("SELECT * from tbl_cust");
            cmd = new MySqlCommand(select, Connection.MySqlConnection);
            read = cmd.ExecuteReader();
            listview.Items.Clear();
            if (read.HasRows)
            {
                while (read.Read())
                {
                    ListViewItem item = new ListViewItem(read.GetValue(0).ToString());
                    item.SubItems.Add(read.GetValue(1).ToString());

                    listview.Items.Add(item);

                }

            }
            Connection.Close();

        }
        public void lvwItemPO(ListView listview)
        {
            //lvwUserList.Items.Clear();
            if (!Connection.IsOpen)
                Connection.Open();
            string select = string.Format("SELECT * from tbl_inventory");
            cmd = new MySqlCommand(select, Connection.MySqlConnection);
            read = cmd.ExecuteReader();
            listview.Items.Clear();
            if (read.HasRows)
            {
                while (read.Read())
                {
                    ListViewItem item = new ListViewItem(read.GetValue(0).ToString());
                    item.SubItems.Add(read.GetValue(1).ToString());
                    item.SubItems.Add(read.GetValue(9).ToString());

                    listview.Items.Add(item);

                }

            }
            Connection.Close();

        }
    }
}
