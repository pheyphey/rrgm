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
    public partial class frmSalesTrans : Form
    {
        ClassListView listview = new ClassListView();
        int qty;
        public frmSalesTrans()
        {
            InitializeComponent();
            listview.lvwTransaction_Items(lvwItemList);
            ClassSalesOrder.DisplaytoLvwCart(lvwCart);
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
                MessageBox.Show("Please select an item!", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtQty.Text) || qty <= 0 )              
                MessageBox.Show("Please put quantity!", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ClassSalesOrder.CheckExistingItem(txt_itemID.Text);

                if (ClassSalesOrder._isAddNewItem)
                    ClassSalesOrder.AddToTemporaryCart(ClassSalesOrder.GeneratePoID("so_cart_id","tbl_cart_so"), txt_itemID.Text, txtDesc.Text, "", int.Parse(txtQty.Text), double.Parse(txtPrc.Text), 1);
                else
                    ClassSalesOrder.UpdateExistingItem(txt_itemID.Text, txtQty.Text);

                ClassSalesOrder.DisplaytoLvwCart(lvwCart);
                ClassSalesOrder.TotalCartItemsAndPrice(lvwCart, lblnumItems, lblTotal);


                //string item = txt_itemID.Text;
                //string desc = txtDesc.Text;
                //ClassTransaction ctrans = new ClassTransaction(lvwCart);
                //ctrans.Add(item, qty, desc);
                //ctrans.computeTotal(lblTotal);
                //ctrans.computeItems(lblnumItems);
                //txt_itemID.Text = string.Empty;
                //txtDesc.Text = string.Empty;
                //txtPrc.Text = string.Empty;
                //txtQty.Text = "1";

            }
        }

        private void lvwItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwItemList.SelectedItems.Count != 0)
            {
                ListViewItem item = lvwItemList.SelectedItems[0];
                txt_itemID.Text = item.SubItems[0].Text;
                txtDesc.Text = item.SubItems[1].Text;
                txtPrc.Text = item.SubItems[2].Text;
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
            //foreach (ListViewItem lvi in lvwCart.SelectedItems)
            //    lvi.Remove();
            //ClassTransaction trans = new ClassTransaction(lvwCart);
            //trans.computeTotal(lblTotal);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboCust_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //frmSample s = new frmSample();
            //s.ShowDialog(this);
        }

        private void cboCust_ID_Enter(object sender, EventArgs e)
        {
            //frmSample s = new frmSample();
            //s.Show();
        }

        private void cboCust_ID_Leave(object sender, EventArgs e)
        {
            frmSample s = new frmSample();
            s.Dispose();
        }

        private void cboCust_ID_Click(object sender, EventArgs e)
        {
            frmSample s = new frmSample();
            s.ShowDialog(this);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ClassSalesOrder.UpdatePendingStatusItems();
            ClassSalesOrder.DisplaytoLvwCart(lvwCart);
        }
    }
}
