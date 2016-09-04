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
    public partial class frmSalesOrder : Form
    {
        ClassListView listview = new ClassListView();
        private MySqlCommand cmd;
        private MySqlDataReader read;

        int qty;
        double prc;
        public frmSalesOrder()
        {
            InitializeComponent();
            listview.lvwItemPO(lvwItemList);
            SupplierList();
            timerQuantity.Start();
        }

        public void SupplierList()
        {
            if (!Connection.IsOpen)
                Connection.Open();
            string select = string.Format("SELECT * from tbl_supplier");
            cmd = new MySqlCommand(select, Connection.MySqlConnection);
            read = cmd.ExecuteReader();
            if (read.HasRows)
                while (read.Read())
                    cboCust_ID.Items.Add(read[0].ToString());
            Connection.Close();
        }
        public string CUST_ID
        {
            set{ cboCust_ID.Text = value;}

        }
        public string CUST_Name
        {
            set { txtStoreName.Text = value; }

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void frmSalesTrans_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w,h);


        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            qty = Convert.ToInt16(txtQty.Text);

            if(string.IsNullOrWhiteSpace(txt_itemID.Text) || string.IsNullOrWhiteSpace(txtDesc.Text))
            {
                MessageBox.Show("Please select an item!", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrWhiteSpace(txtQty.Text) || qty <= 0 )
            {
                
                MessageBox.Show("Please put quantity!", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrWhiteSpace(txtPrc.Text))
            {
                MessageBox.Show("Please put price!", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string item = txt_itemID.Text;
                string desc = txtDesc.Text;
                decimal prc = Decimal.Parse(txtPrc.Text);
                ClassPurchaseOrder ctrans = new ClassPurchaseOrder(lvwCart);
                ctrans.Add(item, qty, desc, prc);
                ctrans.computeTotal(lblTotal);
                ctrans.computeItems(lblnumItems);
                txt_itemID.Text = string.Empty;
                txtDesc.Text = string.Empty;
                txtPrc.Text = string.Empty;
                txtQty.Text = "1";

            }
        }

        private void lvwItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwItemList.SelectedItems.Count != 0)
            {
                ListViewItem item = lvwItemList.SelectedItems[0];
                txt_itemID.Text = item.SubItems[0].Text;
                txtDesc.Text = item.SubItems[1].Text;

            }
            else
            {
                txt_itemID.Text = string.Empty;
                txtDesc.Text = string.Empty;
                txtPrc.Text = string.Empty;

            }
        }

        private void btnRemoveCart_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvwCart.SelectedItems)
                lvi.Remove();
            ClassPurchaseOrder trans = new ClassPurchaseOrder(lvwCart);
            trans.computeTotal(lblTotal);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboCust_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Connection.IsOpen)
                Connection.Open();
            string select = string.Format("SELECT * from tbl_supplier where supplier_ID = '{0}' ", cboCust_ID.Text);
            cmd = new MySqlCommand(select, Connection.MySqlConnection);
            read = cmd.ExecuteReader();

            if (read.HasRows)
            {
                while (read.Read())
                {
                    txtStoreName.Text = read.GetValue(1).ToString();
                    txtAddress.Text = read.GetValue(5).ToString();
                }
            }
            Connection.Close();
        }

        private void cboCust_ID_Enter(object sender, EventArgs e)
        {
            //frmSample s = new frmSample();
            //s.Show();
        }

        private void cboCust_ID_Leave(object sender, EventArgs e)
        {
            //frmSample s = new frmSample();
            //s.Dispose();
        }

        private void cboCust_ID_Click(object sender, EventArgs e)
        {
            //frmSample s = new frmSample();
            //s.ShowDialog(this);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPrc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void timerQuantity_Tick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQty.Text) || int.Parse(txtQty.Text) == 0)
            {
                btnAddCart.Enabled = false;
            }
            else
            {
                btnAddCart.Enabled = true;
            }
        }
    }
}
