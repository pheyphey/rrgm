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
    public partial class frmEditCustomer : Form
    {
        private ClassStructCust structCUST = new ClassStructCust();
        private ClassFMcust fmcust = new ClassFMcust();
        frm_FileMaintenance lvwrefresh = null;
        public frmEditCustomer(frm_FileMaintenance listview)
        {
            InitializeComponent();
            lvwrefresh = listview;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += .05;
            if (this.Opacity == 1)
            {
                timer1.Stop();
            }
        }

        private void frmEditCustomer_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            timer1.Start();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string id
        {
            set { txtCustID.Text = value; }
        }

        public string STORENAME
        {
            set { txtStorename.Text = value; }
        }

        public string LASTNAME
        {
            set { txtLastname.Text = value; }
        }

        public string FIRSTNAME
        {
            set { txtFirstname.Text = value; }
        }

        public string MIDDLEINITIAL
        {
            set { txtMiddlename.Text = value; }
        }

        public string ADDRESS
        {
            set { txtAddress.Text = value; }
        }

        public string PHONE
        {
            set { txttele1.Text = value; }
        }

        public string FAX
        {
            set { txtFax.Text = value; }
        }

        public string EMAIL
        {
            set { txtemail.Text = value; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            structCUST.CUSTID = txtCustID.Text;
            structCUST.STORENAME = txtStorename.Text;
            structCUST.LASTNAME = txtLastname.Text;
            structCUST.FISTNAME = txtFirstname.Text;
            structCUST.MIDDLEINITIAL = txtMiddlename.Text;
            structCUST.ADDRESS = txtAddress.Text;
            structCUST.PHONE = txttele1.Text;
            structCUST.FAX = txtFax.Text;
            structCUST.EMAIL = txtemail.Text;
            fmcust.Update(structCUST);

            lvwrefresh.RefreshUserListView();
            this.Close();
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
