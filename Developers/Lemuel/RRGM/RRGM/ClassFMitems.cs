using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;

namespace RRGM
{
    class ClassFMitems
    {
        private MySqlCommand cmd;
        private MySqlDataReader read;
        ClassStructItems _structItems = new ClassStructItems();

        public void Retrieve(string id)
        {
            if (!Connection.IsOpen)
                Connection.Open();
            string select = string.Format("SELECT * FROM tbl_inventory where item_ID='{0}' ", id);
            cmd = new MySqlCommand(select, Connection.MySqlConnection);
            read = cmd.ExecuteReader();
            if (read.HasRows)
                while (read.Read())
                {
                    _structItems.ITEMID = read.GetValue(0).ToString();
                    _structItems.DESCRIPTION = read.GetValue(1).ToString();
                    _structItems.PRICE = read.GetValue(2).ToString();
                    _structItems.LASTCOSTUNIT = read.GetValue(3).ToString();
                    _structItems.ITEMTYPE = read.GetValue(4).ToString();
                    _structItems.LOCATION = read.GetValue(5).ToString();
                    _structItems.SAFELEVEL = read.GetValue(6).ToString();
                    _structItems.CRITICALLEVEL = read.GetValue(7).ToString();
                    _structItems.REORDERLEVEL = read.GetValue(8).ToString();
                    _structItems.QTYHAND = read.GetValue(9).ToString();
                    _structItems.QTYSO = read.GetValue(10).ToString();
                    _structItems.QTYPO = read.GetValue(11).ToString();
                    _structItems.SUPPLIERID = read.GetValue(12).ToString();
                }
            _structItems.ITEMID = id;
            Connection.Close();
        }

        public void Update(ClassStructItems Items)
        {
            Connection.Open();
            string update = string.Format("UPDATE tbl_inventory SET decsription='{1}',  price='{2}',  last_unit_cost='{3}',  item_type='{4}',  location='{5}',  safe_level='{6}',  critical_level='{7}',  reorder_level='{8}', qty_hand='{9}',  qty_SO='{10}',  qty_PO='{11}',  supplier_ID='{12}' WHERE item_ID='{0}'",
                Items.ITEMID, Items.DESCRIPTION, Items.PRICE, Items.LASTCOSTUNIT, Items.ITEMTYPE, Items.LOCATION, Items.SAFELEVEL, Items.CRITICALLEVEL, Items.REORDERLEVEL, Items.QTYHAND, Items.QTYSO, Items.QTYPO, Items.SUPPLIERID);
            cmd = new MySqlCommand(update, Connection.MySqlConnection);
            read = cmd.ExecuteReader();
            MessageBox.Show("Saved!");

            Connection.Close();
        }

        public void add(ClassStructItems Items)
        {
            Connection.Open();
            string insert = string.Format("INSERT tbl_inventory SET item_ID='{0}', decsription='{1}',  price='{2}',  last_unit_cost='{3}',  item_type='{4}',  location='{5}',  safe_level='{6}',  critical_level='{7}',  reorder_level='{8}', qty_hand='{9}',  qty_SO='{10}',  qty_PO='{11}',  supplier_ID='{12}'",
                 Items.ITEMID, Items.DESCRIPTION, Items.PRICE, Items.LASTCOSTUNIT, Items.ITEMTYPE, Items.LOCATION, Items.SAFELEVEL, Items.CRITICALLEVEL, Items.REORDERLEVEL, Items.QTYHAND, Items.QTYSO, Items.QTYPO, Items.SUPPLIERID);
            cmd = new MySqlCommand(insert, Connection.MySqlConnection);
            read = cmd.ExecuteReader();
            MessageBox.Show("Saved!");

            Connection.Close();
        }
    }
}
