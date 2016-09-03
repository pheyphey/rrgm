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
    public partial class frm_FileMaintenance : Form
    {
       ClassListView listview = new ClassListView();
    
        public frm_FileMaintenance()
        {
            InitializeComponent();
            listview.lvwUser(lvwUser);
            listview.lvwCustomer(lvwCustomer);
            listview.lvwSupplier(lvwSupplier);
        }
        
        private void frm_FileMaintenance_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            timer1.Start();

            timer2.Start();
            label12.Text = DateTime.Now.ToLongDateString();
            label13.Text = DateTime.Now.ToShortTimeString();

            GBusers.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            GBcustomers.Visible = false;
            
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Transparent;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.Transparent;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GBusers.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            GBcustomers.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GBusers.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            GBcustomers.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            GBusers.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            groupBox5.Visible = false;
            GBcustomers.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            GBusers.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = true;
            GBcustomers.Visible = false;
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            GBusers.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            GBcustomers.Visible = true;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.Transparent;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.LightGray;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.LightGray;
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.LightGray;
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.LightGray;
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.LightGray;
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.BackColor = Color.Red;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.BackColor = Color.Transparent;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmAddSup addsup = new frmAddSup(this);
            addsup.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAddInv addinv = new frmAddInv();
            addinv.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmAddCustomer addcust = new frmAddCustomer(this);
            addcust.Show();
        }

        public void RefreshUserListView()
        {
            listview.lvwUser(lvwUser);
            listview.lvwCustomer(lvwCustomer);
            listview.lvwSupplier(lvwSupplier);
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUser add = new frmAddUser(this);
            add.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvwUser.SelectedItems.Count != 0)
            {
                frmEditUser update = new frmEditUser(this);
                update.id = lvwUser.SelectedItems[0].Text;
                update.PASSWORD = lvwUser.SelectedItems[0].SubItems[1].Text;
                update.FIRSTNAME = lvwUser.SelectedItems[0].SubItems[2].Text;
                update.MIDDLENAME = lvwUser.SelectedItems[0].SubItems[3].Text;
                update.LASTNAME = lvwUser.SelectedItems[0].SubItems[4].Text;
                update.POSITION = lvwUser.SelectedItems[0].SubItems[5].Text;

                update.Show(this);
            }
            else
            {
                MessageBox.Show("No Records found.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (lvwCustomer.SelectedItems.Count != 0)
            {
                frmEditCustomer custedit = new frmEditCustomer(this);
                custedit.id = lvwCustomer.SelectedItems[0].Text;
                custedit.STORENAME = lvwCustomer.SelectedItems[0].SubItems[1].Text;
                custedit.LASTNAME = lvwCustomer.SelectedItems[0].SubItems[2].Text;
                custedit.FIRSTNAME = lvwCustomer.SelectedItems[0].SubItems[3].Text;
                custedit.MIDDLEINITIAL = lvwCustomer.SelectedItems[0].SubItems[4].Text;
                custedit.ADDRESS = lvwCustomer.SelectedItems[0].SubItems[5].Text;
                custedit.PHONE = lvwCustomer.SelectedItems[0].SubItems[6].Text;
                custedit.FAX = lvwCustomer.SelectedItems[0].SubItems[7].Text;
                custedit.EMAIL = lvwCustomer.SelectedItems[0].SubItems[8].Text;
                custedit.SALEMAN = lvwCustomer.SelectedItems[0].SubItems[9].Text;
                custedit.PAYMENTTERM = lvwCustomer.SelectedItems[0].SubItems[10].Text;
                custedit.PAYMENTMETHOD = lvwCustomer.SelectedItems[0].SubItems[11].Text;
                custedit.BANKACCOUNT = lvwCustomer.SelectedItems[0].SubItems[12].Text;
                custedit.CREDITLIMIT = lvwCustomer.SelectedItems[0].SubItems[13].Text;
                custedit.OPENBALANCE = lvwCustomer.SelectedItems[0].SubItems[14].Text;
                custedit.CURRENTBALANCE = lvwCustomer.SelectedItems[0].SubItems[15].Text;
                custedit.Show(this);
            }
            else
            {
                MessageBox.Show("No Records found.");
            }

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (lvwSupplier.SelectedItems.Count != 0)
            {
                frmEditSupp suppedit = new frmEditSupp(this);
                suppedit.id = lvwSupplier.SelectedItems[0].Text;
                suppedit.STORENAME = lvwSupplier.SelectedItems[0].SubItems[1].Text;
                suppedit.LASTNAME = lvwSupplier.SelectedItems[0].SubItems[2].Text;
                suppedit.FIRSTNAME = lvwSupplier.SelectedItems[0].SubItems[3].Text;
                suppedit.MIDDLEINITIAL = lvwSupplier.SelectedItems[0].SubItems[4].Text;
                suppedit.ADDRESS = lvwSupplier.SelectedItems[0].SubItems[5].Text;
                suppedit.PHONE = lvwSupplier.SelectedItems[0].SubItems[6].Text;
                suppedit.FAX = lvwSupplier.SelectedItems[0].SubItems[7].Text;
                suppedit.EMAIL = lvwSupplier.SelectedItems[0].SubItems[8].Text;
                suppedit.SALEMAN = lvwSupplier.SelectedItems[0].SubItems[9].Text;
                suppedit.PAYMENTTERM = lvwSupplier.SelectedItems[0].SubItems[10].Text;
                suppedit.PAYMENTMETHOD = lvwSupplier.SelectedItems[0].SubItems[11].Text;
                suppedit.BANKACCOUNT = lvwSupplier.SelectedItems[0].SubItems[12].Text;
                suppedit.CREDITLIMIT = lvwSupplier.SelectedItems[0].SubItems[13].Text;
                suppedit.OPENBALANCE = lvwSupplier.SelectedItems[0].SubItems[14].Text;
                suppedit.CURRENTBALANCE = lvwSupplier.SelectedItems[0].SubItems[15].Text;
                suppedit.Show(this);
            }
            else
            {
                MessageBox.Show("No Records found.");
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            label13.Text = DateTime.Now.ToShortTimeString();
            timer2.Start();
        }
    }
}
