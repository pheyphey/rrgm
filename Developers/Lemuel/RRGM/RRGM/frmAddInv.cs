using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRGM
{
    public partial class frmAddInv : Form
    {
        GenerateID _getID = new GenerateID();
        ClassStructItems _structITEMS = new ClassStructItems();
        ClassFMitems _fmITEMS = new ClassFMitems();
        frm_FileMaintenance _lvw = null;
        public frmAddInv(frm_FileMaintenance listview)
        {
            InitializeComponent();
            _lvw = listview;
            _getID.setID("item_ID", "tbl_inventory", "ITEM-", 5);
            txtItemID.Text = _getID.ID;
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text == "" || txtItemID.Text == "" || txtItemType.Text == "" || txtLastUnitCost.Text == "" || txtLocation.Text == "" || txtPrefVendorID.Text == "" || txtPrice.Text == "" || txtQtyOnHand.Text == "" || txtQtyOnPO.Text == "" || txtQtyOnSO.Text == "") 
            {
                MessageBox.Show("Please fill out the following fields.", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _structITEMS.ITEMID = txtItemID.Text;
                _structITEMS.DESCRIPTION = txtDescription.Text;
                _structITEMS.PRICE = txtPrice.Text;
                _structITEMS.LASTCOSTUNIT = txtLastUnitCost.Text;
                _structITEMS.ITEMTYPE = txtItemType.Text;
                _structITEMS.LOCATION = txtLocation.Text;
                _structITEMS.SAFELEVEL = txtsafelvl.Text;
                _structITEMS.CRITICALLEVEL = txtCriticallvl.Text;
                _structITEMS.REORDERLEVEL = txtReorderlvl.Text;
                _structITEMS.QTYHAND = txtQtyOnHand.Text;
                _structITEMS.QTYSO = txtQtyOnSO.Text;
                _structITEMS.QTYPO = txtQtyOnPO.Text;
                _structITEMS.SUPPLIERID = txtPrefVendorID.Text;
                _fmITEMS.add(_structITEMS);

                _lvw.RefreshUserListView();
                this.Hide();
            }
        }

        private void frmAddInv_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += .05;
            if (this.Opacity == 1)
            {
                timer1.Stop();
            }
        }
    }
}
