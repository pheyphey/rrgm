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
    public partial class frmEditUser : Form
    {
        private ClassStructUser structuser = new ClassStructUser();
        private ClassFMuser fmuser = new ClassFMuser();
        frm_FileMaintenance lvwrefresh = null;
        public frmEditUser( frm_FileMaintenance listview)
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

        private void frmEditUser_Load(object sender, EventArgs e)
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
            set
            {
                txtUserID.Text = value;
            }

        }

        public string FIRSTNAME
        {
            set
            {
                txtFirstname.Text = value;
            }

        }

        public string MIDDLENAME
        {
            set
            {
                txtMiddlename.Text = value;
            }

        }

        public string LASTNAME
        {
            set
            {
                txtLastname.Text = value;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            structuser.USERID = txtUserID.Text;
            structuser.FIRSTNAME = txtFirstname.Text;
            structuser.PASSWORD = txtPassword.Text;
            structuser.MIDDLENAME = txtMiddlename.Text;
            structuser.LASTNAME = txtLastname.Text;
            structuser.POSITION = txtPosition.Text;
            fmuser.Update(structuser);
            lvwrefresh.RefreshUserListView();
            this.Close();
        }
    }
}

