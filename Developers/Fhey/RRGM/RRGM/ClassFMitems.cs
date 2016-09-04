using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace RRGM
{
    class ClassFMitems
    {
        private MySqlCommand cmd;
        private MySqlDataReader read;
        ClassStructItems structitems = new ClassStructItems();

        public void Retrieve(string id)
        {

            if (!Connection.IsOpen)
                Connection.Open();
            string select = string.Format("SELECT * FROM tbl_inventory where userid='{0}' ", id);
            cmd = new MySqlCommand(select, Connection.MySqlConnection);
            read = cmd.ExecuteReader();
            if (read.HasRows)
                while (read.Read())
                {
                    structitems.ITEM_ID = read.GetValue(0).ToString();
                    structitems.ITEM_DESC = read.GetValue(1).ToString();
                    structitems.PRICE = read.GetValue(2).ToString();
                    structitems.LAST_UNIT_COST = read.GetValue(3).ToString();
                    structitems.ITEM_TYPE = read.GetValue(4).ToString();
                    structitems.LOCATION = read.GetValue(5).ToString();
                    structitems.SAFE_LEVEL = read.GetValue(6).ToString();
                    structitems.CRITICAL_LEVEL = read.GetValue(7).ToString();
                    structitems.REORDER_LEVEL = read.GetValue(8).ToString();
                    structitems.QTY_HAND = read.GetValue(9).ToString();
                    structitems.QTY_SO = read.GetValue(10).ToString();
                    structitems.QTY_PO = read.GetValue(11).ToString();
                    structitems.PREFFERED_SUPPLIER_ID = read.GetValue(12).ToString();
                }
            structitems.ITEM_ID = id;
            Connection.Close();
        }

        public void Update(ClassStructItems items)
        {
            // if (Connection.IsOpen)
            Connection.Open();
            string update = string.Format("UPDATE tbl_inventory SET description='{1}',  price='{2}',    last_unit_cost='{3}',   item_type='{4}', location='{5}', safe_level='{6}', critical_level='{7}', reorder_level='{8}', qty_hand='{9}',qty_SO='{10}', qty_PO='{11}', supplier_ID='{6}' WHERE item_ID='{0}'  ",
                items.ITEM_ID, items.ITEM_DESC, items.PRICE, items.LAST_UNIT_COST, items.ITEM_TYPE, items.LOCATION, items.SAFE_LEVEL, items.CRITICAL_LEVEL,
                items.REORDER_LEVEL, items.QTY_HAND, items.QTY_SO, items.QTY_PO, items.PREFFERED_SUPPLIER_ID);
            cmd = new MySqlCommand(update, Connection.MySqlConnection);
            read = cmd.ExecuteReader();
            MessageBox.Show("Saved!");

            Connection.Close();
        }

        public void Add(ClassStructItems items)
        {
            // if (Connection.IsOpen)
            Connection.Open();
            string update = string.Format("INSERT tbl_inventory SET item_ID='{0}',description='{1}',  price='{2}',    last_unit_cost='{3}',   item_type='{4}', location='{5}', safe_level='{6}', critical_level='{7}', reorder_level='{8}', qty_hand='{9}',qty_SO='{10}', qty_PO='{11}', supplier_ID='{6}' ",
                items.ITEM_ID, items.ITEM_DESC, items.PRICE, items.LAST_UNIT_COST, items.ITEM_TYPE, items.LOCATION, items.SAFE_LEVEL, items.CRITICAL_LEVEL,
                items.REORDER_LEVEL, items.QTY_HAND, items.QTY_SO, items.QTY_PO, items.PREFFERED_SUPPLIER_ID);
            cmd = new MySqlCommand(update, Connection.MySqlConnection);
            read = cmd.ExecuteReader();
            MessageBox.Show("Saved!");

            Connection.Close();
        }
    }
}
