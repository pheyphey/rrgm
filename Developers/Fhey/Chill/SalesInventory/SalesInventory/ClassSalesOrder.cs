using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace SalesInventory
{
    class ClassSalesOrder
    {

        internal static MySqlCommand cmd;
        internal static MySqlDataReader read;

        internal static int _poID;
        internal static bool _isAddNewItem = false;
        internal static string _qty = "";
        internal static string _price = "";

        internal static int GeneratePoID(string column, string table)
        {
            Connection.Open();
            string query = string.Format("SELECT {0} FROM {1} ORDER BY {0} DESC LIMIT 1", column, table);
            cmd = new MySqlCommand(query, Connection.MySqlConnection);
            string sID = cmd.ExecuteScalar().ToString();
            Connection.Close();

            return _poID = int.Parse(sID) + 1;
        }

        internal static void ItemTypeSelect(TextBox txt)
        { }

        internal static void TotalCartItemsAndPrice(ListView lv, Label itemCart, Label subTotal)
        {
            double value = 0;
            int cartItems = 0;
            for (int i = 0; i < lv.Items.Count; i++)
            {
                value += double.Parse(lv.Items[i].SubItems[5].Text);
                cartItems += int.Parse(lv.Items[i].SubItems[3].Text);
            }
            string totalValue = string.Format("{0:n2}", value);
            subTotal.Text = totalValue.ToString();
            itemCart.Text = cartItems.ToString();
        } 

        internal static void UpdatePendingStatusItems()
        {
            Connection.Open();
            string update = string.Format("UPDATE tbl_cart_so SET so_flag='{0}' WHERE so_flag='{1}'  ", "0", "1");
            cmd = new MySqlCommand(update, Connection.MySqlConnection);
            read = cmd.ExecuteReader();
            MessageBox.Show("Succesfully Saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.Close();
        }

        internal static void DisplaytoLvwCart(ListView listview)
        {
            Connection.Open();
            cmd = new MySqlCommand("SELECT * FROM tbl_cart_so WHERE so_flag='1' ORDER BY so_cart_id ASC", Connection.MySqlConnection);
            read = cmd.ExecuteReader();
            listview.Items.Clear();
            if (read.HasRows)
                while (read.Read())
                {
                    ListViewItem lv = new ListViewItem(read[1].ToString());
                    lv.SubItems.Add(read[2].ToString());
                    lv.SubItems.Add(read[3].ToString());
                    lv.SubItems.Add(read[4].ToString());
                    lv.SubItems.Add(string.Format("{0:n2}", read[5]));
                    lv.SubItems.Add(string.Format("{0:n2}", read[6]));
                    listview.Items.Add(lv);
                }
            Connection.Close();
        }
        // int.Parse(txtQty.Text), double.Parse(txtPrc.Text)
        internal static void CheckExistingItem(string itemID)
        {
            Connection.Open();
            string select = string.Format("SELECT so_qty, so_price FROM tbl_cart_so WHERE so_item_id='{0}' AND so_flag='1'      ", itemID);
            cmd = new MySqlCommand(select, Connection.MySqlConnection);
            read = cmd.ExecuteReader();
            if (read.HasRows)
            {
                _isAddNewItem = false;

                while (read.Read())
                {
                    _qty = read[0].ToString();
                    _price = read[1].ToString();
                }
            }
            else
                _isAddNewItem = true;

            Connection.Close();
        }

        internal static void UpdateExistingItem(string itemID, string qty)
        {
            int newQty = int.Parse(qty) + int.Parse(_qty);
            double subTotal = newQty * double.Parse(_price);

            Connection.Open();
            string update = string.Format("UPDATE tbl_cart_so SET so_qty='{0}', so_subtotal='{1}' WHERE so_item_id='{2}'      ", newQty, subTotal, itemID);
            cmd = new MySqlCommand(update, Connection.MySqlConnection);
            read = cmd.ExecuteReader();
            Connection.Close();

        }

        internal static void AddToTemporaryCart(int id, string code, string desc, string type, int qty, double price, int flag)
        {
            double subTotal = qty * price;

            Connection.Open();
            string insert = string.Format("INSERT tbl_cart_so SET so_cart_id='{0}', so_item_id='{1}', so_item_desc='{2}', so_item_type='{3}', so_qty='{4}', so_price='{5}', so_subtotal='{6}', so_flag='{7}'      ", id, code, desc, type, qty, price, subTotal, flag );
            cmd = new MySqlCommand(insert, Connection.MySqlConnection);
            read = cmd.ExecuteReader();
            Connection.Close();

        }




    }
}
