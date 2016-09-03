using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace RRGM
{
    public partial class frm_login : Form
    {
       
        public frm_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=";
                MySqlConnection myconn = new MySqlConnection(myConnection);
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                MySqlCommand SelectCommand = new MySqlCommand(" select * from dbrrgm.tbluser where userID='" + this.txtusername.Text + "'and password='" + this.txtpassword.Text + "';", myconn);

                MySqlDataReader myReader;
                myconn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)

                {
                    MessageBox.Show("Login Success");

                    Form1 asasa = new Form1();
                    asasa.Show();
                    Hide();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Username and password ...Access denied");
                }
                else
                {
                    txtpassword.Text = "";
                    txtusername.Text = "";
                    MessageBox.Show("Incorrect Username/Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.LightGray;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Transparent;
        }
    }
}
