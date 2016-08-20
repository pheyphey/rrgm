using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesInventory
{
    public partial class frmUpdateItems : Form
    {
        ClassFM_Items fm_items = new ClassFM_Items();
        ClassStructItems structitems = new ClassStructItems();
        frmFileMaintenance fm = new frmFileMaintenance();
        frmFileMaintenance lvwrefresh = null;
        public frmUpdateItems(frmFileMaintenance listview)
        {
            InitializeComponent();
            lvwrefresh = listview;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            structitems.ITEM_ID = txtItemID.Text;
            structitems.ITEM_DESC = txtDesc.Text;
            structitems.PRICE = txtPrc.Text;
            structitems.LAST_UNIT_COST = txtLastCost.Text;
            structitems.ITEM_TYPE = txtType.Text;
            structitems.LOCATION = txtLoc.Text;
            structitems.SAFE_LEVEL = txtSafeLvl.Text;
            structitems.CRITICAL_LEVEL = txtCricLvl.Text;
            structitems.REORDER_LEVEL = txtReordrLvL.Text;
            structitems.QTY_HAND = txtQtyHnd.Text;
            structitems.QTY_SO = txtQtySO.Text;
            structitems.QTY_PO = txtQtyPO.Text;
            structitems.PREFFERED_SUPPLIER_ID = txtSupID.Text;

            fm_items.Update(structitems);
            lvwrefresh.RefreshListView();
            this.Hide();
        }
        public string items_id
        {
            set { txtItemID.Text = value; }

        }
        public string description
        {
            set { txtDesc.Text = value; }
        }

        public string price
        {
            set { txtPrc.Text = value; }
        }

        public string last_unit_cost
        {
            set { txtLastCost.Text = value; }
        }

        public string item_type
        {
            set { txtType.Text = value; }
        }

        public string location
        {
            set { txtLoc.Text = value; }
        }

        public string safe_lvl
        {
            set { txtSafeLvl.Text = value; }
        }
        
        public string critical_lvl
        {
            set { txtCricLvl.Text = value; }
        }

        public string reorder_lvl
        {
            set { txtReordrLvL.Text = value; }
        }

        public string qty_hand
        {
            set { txtQtyHnd.Text = value; }
        }

        public string qty_so
        {
            set { txtQtySO.Text = value; }
        }

        public string qty_po
        {
            set { txtQtyPO.Text = value; }
        }

        public string supplier_id
        {
            set { txtSupID.Text = value; }
        }

    }
}
