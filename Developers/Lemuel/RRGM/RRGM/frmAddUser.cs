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
    public partial class frmAddUser : Form
    {
        GenerateID _genID = new GenerateID();
        ClassStructUser _structUSER = new ClassStructUser();
        ClassFMuser _fmUSER = new ClassFMuser();
        frm_FileMaintenance _lvw = null;

        public frmAddUser(frm_FileMaintenance listview)
        {
            InitializeComponent();
            _lvw = listview;
            _genID.setID("userID", "tbluser", "USER-", 5);
            txtUserID.Text = _genID.ID;
        }

        private void frmAddUser_Load(object sender, EventArgs e)
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
            if (txtFirstname.Text=="" || txtLastname.Text=="" || txtMiddlename.Text=="" || txtUserID.Text=="" || txtPassword.Text == "" || txtPosition.Text=="" || txtPosition.Text == "Select a Position..")
            {
                MessageBox.Show("Please fill out the following fields.", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _structUSER.USERID = txtUserID.Text;
                _structUSER.FIRSTNAME = txtFirstname.Text;
                _structUSER.PASSWORD = txtPassword.Text;
                _structUSER.MIDDLENAME = txtMiddlename.Text;
                _structUSER.LASTNAME = txtLastname.Text;
                _structUSER.POSITION = txtPosition.Text;
                _fmUSER.Add(_structUSER);

                _lvw.RefreshUserListView();
                this.Hide();
            }
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
