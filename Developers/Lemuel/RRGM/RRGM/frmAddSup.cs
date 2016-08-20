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
    public partial class frmAddSup : Form
    {
        GenerateID _getID = new GenerateID();
        ClassStructSupp _structSUPP = new ClassStructSupp();
        ClassFMsupp _fmSUPP = new ClassFMsupp();
        frm_FileMaintenance _lvw = null;
        public frmAddSup(frm_FileMaintenance listview)
        {
            InitializeComponent();
            _lvw = listview;
            _getID.setID("supplier_ID", "tbl_supplier", "SUPP-", 5);
            txtSuppID.Text = _getID.ID;
        }

        private void frmAddSup_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            timer1.Start();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtBankAccountNum.Text == "" || txtCreditLimit.Text == "" || txtCreditStatus.Text == "" || txtemail.Text == "" || txtFax.Text == "" || txtFirstname.Text == "" || txtLastname.Text == "" || txtMiddlename.Text == "" || txtOpeningBalance.Text == "" || txtPaymentMethod.Text == "" || txtPaymentTerm.Text == "" || txtSaleDiscount.Text == "" || txtsalesman.Text == "" || txtStoreName.Text == "" || txttele1.Text == "" || txttele1.Text == "")
            {
                MessageBox.Show("Please fill out the following fields.", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _structSUPP.SUPPID = txtSuppID.Text;
                _structSUPP.STORENAME = txtStoreName.Text;
                _structSUPP.LASTNAME = txtLastname.Text;
                _structSUPP.FISTNAME = txtFirstname.Text;
                _structSUPP.MIDDLEINITIAL = txtMiddlename.Text;
                _structSUPP.ADDRESS = txtAddress.Text;
                _structSUPP.PHONE = txttele1.Text;
                _structSUPP.FAX = txtFax.Text;
                _structSUPP.EMAIL = txtemail.Text;
                _structSUPP.SALEMAN = txtsalesman.Text;
                _structSUPP.PAYMENTTERM = txtPaymentTerm.Text;
                _structSUPP.PAYMENTMETHOD = txtPaymentMethod.Text;
                _structSUPP.BANKACCOUNT = txtBankAccountNum.Text;
                _structSUPP.CREDITLIMIT = txtCreditLimit.Text;
                _structSUPP.OPENBALANCE = txtOpeningBalance.Text;
                _structSUPP.CURRENTBALANCE = txtCreditStatus.Text;
                _fmSUPP.add(_structSUPP);

                _lvw.RefreshUserListView();
                this.Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += .05;
            if (this.Opacity == 1)
            {
                timer1.Stop();
            }
        }

        private void txttele1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCreditLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtOpeningBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCreditStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
