using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SalesInventory
{
    class ClassPurchaseOrder
    {
        ListView lvwcart;
        
        string type;
        private MySqlCommand cmd;
        private MySqlDataReader read;

        public ClassPurchaseOrder(ListView _lvwcart)
        {
            this.lvwcart = _lvwcart;
        }

        public void Add(string item_ID, int qty, string item_desc, decimal prc)
        {
            ListViewItem lvwItem = new ListViewItem();
            decimal total;
            
            getType(item_ID);
            total = qty * prc;
            if (lvwcart.Items.Count == 0)
            {
                lvwItem = new ListViewItem(item_ID, 0);
                lvwItem.SubItems.Add(item_desc);
                lvwItem.SubItems.Add(type);
                lvwItem.SubItems.Add(qty.ToString());
                lvwItem.SubItems.Add(prc.ToString("#,###0.00"));
                lvwItem.SubItems.Add(total.ToString("#,###0.00"));
                lvwcart.Items.AddRange(new ListViewItem[] { lvwItem });
            }
            else
            {
                int x = 0;
                int new_qty = 0;
                int cartcount = lvwcart.Items.Count;
                decimal new_total = 0.0M;

                foreach (ListViewItem i in lvwcart.Items)
                {
                    x++;
                    if (item_ID.Equals(i.SubItems[5].Text))
                    {
                        new_qty = qty + (Convert.ToInt32(i.Text));
                        new_total = new_qty * prc;
                        lvwcart.Items[x - 1].Text = Convert.ToString(new_qty);
                        lvwcart.Items[x - 1].SubItems[3].Text = Convert.ToString(new_total);
                        break;
                    }
                    else if (x == cartcount)
                    {
                        lvwItem = new ListViewItem(item_ID, 0);
                        lvwItem.SubItems.Add(item_desc);
                        lvwItem.SubItems.Add(type);
                        lvwItem.SubItems.Add(qty.ToString());
                        lvwItem.SubItems.Add(prc.ToString("#,###0.00"));
                        lvwItem.SubItems.Add(total.ToString("#,###0.00"));
                        lvwcart.Items.AddRange(new ListViewItem[] { lvwItem });
                    }
                }
            }


        }

        public void computeTotal(Label amount)
        {
            decimal due;
            due = 0.0M;
            foreach (ListViewItem lvi in lvwcart.Items)
            {
                due += decimal.Parse(lvi.SubItems[5].Text);
            }
            amount.Text = due.ToString("#,###0.00");
        }

        public void computeItems(Label numItems)
        {
            decimal due;
            due = 0.0M;
            foreach (ListViewItem lvi in lvwcart.Items)
            {
                due += decimal.Parse(lvi.SubItems[3].Text);
            }
            numItems.Text = due.ToString("#,###0");
        }



        public void getType(string prod)
        {
            if (!Connection.IsOpen)
                Connection.Open();
            string select = string.Format("SELECT item_type FROM tbl_inventory WHERE item_ID='{0}' ", prod);
            cmd = new MySqlCommand(select, Connection.MySqlConnection);
            read = cmd.ExecuteReader();
            if (read.HasRows)
            {
                while (read.Read())
                {
                    type = read.GetValue(0).ToString();


                }

            }
            Connection.Close();
        }



    }
}
