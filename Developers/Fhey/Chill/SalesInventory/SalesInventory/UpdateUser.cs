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
    public partial class frmUpdateUser : Form
    {
        private FMuser fmuser = new FMuser();
        private StructUser structuser = new StructUser();
        private ClassListView listview = new ClassListView();
        private frmFileMaintenance fm = new frmFileMaintenance();
        frmFileMaintenance lvwrefresh = null;

        //public static frmUpdateUser UpdateUser;
        public frmUpdateUser()
        {
            InitializeComponent();
           // UpdateUser = this;
        }
        public frmUpdateUser(frmFileMaintenance listview)
        {
            InitializeComponent();
            lvwrefresh = listview;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            structuser.USERID = txtUserID.Text;
            structuser.FIRSTNAME = txtFirstName.Text;
            structuser.PASSWORD = txtPassword.Text;
            structuser.MIDDLENAME = txtMiddleName.Text;
            structuser.LASTNAME = txtLastName.Text;
            structuser.POSITION = txtPosition.Text;
            fmuser.Update(structuser);
            //listview.lvwUser()
            //fm.Application
            //frmFileMaintenance.formFM.Invalidate();
            // frmFileMaintenance.formFM.Refresh();
            //fm.RefreshListView();

            lvwrefresh.RefreshListView();
            this.Hide();



        }
        public string id
        {
            set
            {
                txtUserID.Text = value;
            }

        }

        public string FIRSTNAME
        {
            set
            {
                txtFirstName.Text = value;
            }

        }

        public string MIDDLENAME
        {
            set
            {
                txtMiddleName.Text = value;
            }

        }

        public string LASTNAME
        {
            set
            {
                txtLastName.Text = value;
            }

        
        }
        public string PASSWORD
        {
            set
            {
                txtPassword.Text = value;
            }

        }
        public string POSITION
        {
            set
            {
               txtPosition.Text = value;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmUpdateUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            //fm.RefreshListView();
            //fm.Dispose();
           // Application.Exit();
        }
    }
}
