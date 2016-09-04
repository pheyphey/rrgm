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
        public frmAddInv()
        {
            InitializeComponent();
            
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCostMethod.Text == "" || txtDescription.Text == "" || txtItemID.Text == "" || txtItemType.Text == "" || txtLastUnitCost.Text == "" || txtLocation.Text == "" || txtPrefVendorID.Text == "" || txtPrice.Text == "" || txtQtyOnHand.Text == "" || txtQtyOnPO.Text == "" || txtQtyOnSO.Text == "" || txtStockingUM.Text == "") 
            {
                MessageBox.Show("Please fill out the following fields.", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
