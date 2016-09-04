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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label8.Text = DateTime.Now.ToLongDateString();
            label12.Text = DateTime.Now.ToShortTimeString();

            this.Opacity = 0.1;
            timer2.Start();

            this.Enabled = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            //pictureBox11.BackColor = Color.Transparent;
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.BackColor = Color.Transparent;
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frm_Inquiryy inquiry = new frm_Inquiryy();
            inquiry.Show();
        }

        private void pictureBox9_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox9.BackColor = Color.Transparent;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            frm_FileMaintenance fm = new frm_FileMaintenance();
            fm.Show(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label12.Text = DateTime.Now.ToShortTimeString();
            timer1.Start();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.LightGray;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.LightGray;
        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            //pictureBox11.BackColor = Color.LightGray;
        }

        private void pictureBox12_MouseEnter(object sender, EventArgs e)
        {
            pictureBox12.BackColor = Color.LightGray;
        }

        private void pictureBox13_MouseEnter(object sender, EventArgs e)
        {
            pictureBox13.BackColor = Color.LightGray;
        }

        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.BackColor = Color.LightGray;
        }

        private void pictureBox15_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show(new Form {TopMost = true},  "Do you want to logout?", "System", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name != "frm_login")
                        Application.OpenForms[i].Close();
                        frm_login login = new frm_login();
                        login.Show();
                }
            }
        }

        private void pictureBox15_MouseEnter(object sender, EventArgs e)
        {
            pictureBox15.BackColor = Color.Red;
        }

        private void pictureBox15_MouseLeave(object sender, EventArgs e)
        {
            pictureBox15.BackColor = Color.Transparent;
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.LightGray;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.Transparent;
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.LightGray;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.LightGray;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.Transparent;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {     
            this.Opacity += .05;
            if (this.Opacity == 1)
            {
                timer2.Stop();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frm_SalesTrans SalesTrans = new frm_SalesTrans();
            SalesTrans.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
