using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SalesInventory
{
    public partial class frmAddUser : Form
    {
        private MySqlCommand cmd;
        private MySqlDataReader read;

        StructUser structuser = new StructUser();
        FMuser fmuser = new FMuser();
        frmFileMaintenance fm = new frmFileMaintenance();
        frmFileMaintenance lvw = null;
        private GenerateID _genID = new GenerateID();

        public frmAddUser(frmFileMaintenance listview)
        {
            InitializeComponent();
            lvw = listview;
            _genID.setID("userID", "tbluser", "USER-",5);
            txtUserID.Text = _genID.ID;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            structuser.USERID = txtUserID.Text;
            structuser.FIRSTNAME = txtFirstName.Text;
            structuser.PASSWORD = txtPassword.Text;
            structuser.MIDDLENAME = txtMiddleName.Text;
            structuser.LASTNAME = txtLastName.Text;
            structuser.POSITION = txtPosition.Text;
            fmuser.Add(structuser);

            lvw.RefreshListView();
            this.Hide();






        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            //if (Connection.IsOpen)
            //{

            //    StructUser user = new StructUser();
            //    string generate = string.Format("SELECT MID(userID,6,6) FROM tbluser ORDER BY userID DESC LIMIT 1;");
            //    cmd = new MySqlCommand(generate, Connection.MySqlConnection);
            //    read = cmd.ExecuteReader();

            //    read.Read();
            //    if (read.HasRows)
            //    {

            //        int code = read.GetInt16(0) + 1;
            //        txtUserID.Text = "USER-" + code.ToString("0000");


            //    }
            //    else
            //    {
            //        txtUserID.Text = "USER-" + "0001";
            //    }

            //    Connection.Close();
            //fmuser.GenerateID();
            //txtUserID.Text = structuser.USERID;
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

