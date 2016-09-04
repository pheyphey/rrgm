using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace RRGM
{
    class ClassListView
    {
        private MySqlCommand cmd;
        private MySqlDataReader read;
        public void lvwUser(ListView listview)
        {
            
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

        public void lvwCustomer(ListView listview)
        {
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
                    item.SubItems.Add(read.GetValue(2).ToString());
                    item.SubItems.Add(read.GetValue(3).ToString());
                    item.SubItems.Add(read.GetValue(4).ToString());
                    item.SubItems.Add(read.GetValue(5).ToString());
                    item.SubItems.Add(read.GetValue(6).ToString());
                    item.SubItems.Add(read.GetValue(7).ToString());
                    item.SubItems.Add(read.GetValue(8).ToString());
                    listview.Items.Add(item);
                }
            }
            Connection.Close();
        }

        public void lvwSupplier(ListView listview)
        {
            if (!Connection.IsOpen)
                Connection.Open();
            string select = string.Format("SELECT * from tbl_supplier");
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
                    listview.Items.Add(item);
                }
            }
            Connection.Close();
        }
        public void lvwItems(ListView listview)
        {
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
    }
}
