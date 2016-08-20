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
    public partial class frmAddInv : Form
    {
        ClassStructItems structitems = new ClassStructItems();
        ClassFM_Items fm_items = new ClassFM_Items();
        frmFileMaintenance frmFM = new frmFileMaintenance();
        frmFileMaintenance lvw = null;
        private GenerateID _genID = new GenerateID();
        public frmAddInv(frmFileMaintenance listview)
        {
            InitializeComponent();
            lvw = listview;
            _genID.setID("item_ID", "tbl_inventory", "item-", 5);
            txtItemID.Text = _genID.ID;
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

            fm_items.Add(structitems);
            lvw.RefreshListView();
            this.Hide();
        }
    }
}
