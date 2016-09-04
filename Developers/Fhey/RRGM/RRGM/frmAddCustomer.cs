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
    public partial class frmAddCustomer : Form
    {
        GenerateID _getID = new GenerateID();
        ClassStructCust _structCUST = new ClassStructCust();
        ClassFMcust _fmCUST = new ClassFMcust();
        frm_FileMaintenance _lvw = null;
        public frmAddCustomer(frm_FileMaintenance listview)
        {
            InitializeComponent();
            _lvw = listview;
            _getID.setID("cust_ID", "tbl_cust", "CUST-", 5);
            txtCustID.Text = _getID.ID;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += .05;
            if (this.Opacity == 1)
            {
                timer1.Stop();
            }
        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            timer1.Start();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtBankAccountNum.Text == "" || txtCreditLimit.Text == "" || txtCreditStatus.Text == "" || txtemail.Text == "" || txtFax.Text == "" || txtFirstname.Text == "" || txtLastname.Text == "" || txtMiddlename.Text == "" || txtOpeningBalance.Text == "" || txtPaymentMethod.Text == "" || txtPaymentTerm.Text == "" || txtSaleDiscount.Text == "" || txtsalesman.Text == "" || txtStorename.Text == "" || txttele1.Text == "" || txttele1.Text == "")
            {
                MessageBox.Show("Please fill out the following fields.", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _structCUST.CUSTID = txtCustID.Text;
                _structCUST.STORENAME = txtStorename.Text;
                _structCUST.LASTNAME = txtLastname.Text;
                _structCUST.FISTNAME = txtFirstname.Text;
                _structCUST.MIDDLEINITIAL = txtMiddlename.Text;
                _structCUST.ADDRESS = txtAddress.Text;
                _structCUST.PHONE = txttele1.Text;
                _structCUST.FAX = txtFax.Text;
                _structCUST.EMAIL = txtemail.Text;
                _structCUST.SALEMAN = txtsalesman.Text;
                _structCUST.PAYMENTTERM = txtPaymentTerm.Text;
                _structCUST.PAYMENTMETHOD = txtPaymentMethod.Text;
                _structCUST.BANKACCOUNT = txtBankAccountNum.Text;
                _structCUST.CREDITLIMIT = txtCreditLimit.Text;
                _structCUST.OPENBALANCE = txtOpeningBalance.Text;
                _structCUST.CURRENTBALANCE = txtCreditStatus.Text;
                _fmCUST.add(_structCUST);

                _lvw.RefreshUserListView();
                this.Hide();
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
    }
}
