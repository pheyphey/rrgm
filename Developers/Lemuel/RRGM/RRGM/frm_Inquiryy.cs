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
    public partial class frm_Inquiryy : Form
    {
        public frm_Inquiryy()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnItemList_Click(object sender, EventArgs e)
        {
            btnItemList.BackColor = Color.LightGray;
            btncustlist.BackColor = Color.Transparent;
            btnVendorList.BackColor = Color.Transparent;
            btnTruckList.BackColor = Color.Transparent;
            btnSalesOrderList.BackColor = Color.Transparent;
            btnPurchaseOrderList.BackColor = Color.Transparent;


            GBItemList.Visible = true;
            GBvendorList.Visible = false;
            GBsalesOrderList.Visible = true;
            GBPurchaseOrder.Visible = false;
            GBtruckList.Visible = false;
            GBCustList.Visible = false;
        }

        private void btncustlist_Click(object sender, EventArgs e)
        {
            btnItemList.BackColor = Color.Transparent;
            btncustlist.BackColor = Color.LightGray;
            btnVendorList.BackColor = Color.Transparent;
            btnTruckList.BackColor = Color.Transparent;
            btnSalesOrderList.BackColor = Color.Transparent;
            btnPurchaseOrderList.BackColor = Color.Transparent;

            GBCustList.Visible = true;
            GBsalesOrderList.Visible = false;
            GBPurchaseOrder.Visible = false;
            GBvendorList.Visible = false;
            GBtruckList.Visible = false;
            GBItemList.Visible = false;
        }

        private void btnVendorList_Click(object sender, EventArgs e)
        {
            btnItemList.BackColor = Color.Transparent;
            btncustlist.BackColor = Color.Transparent;
            btnVendorList.BackColor = Color.LightGray;
            btnTruckList.BackColor = Color.Transparent;
            btnSalesOrderList.BackColor = Color.Transparent;
            btnPurchaseOrderList.BackColor = Color.Transparent;

            GBvendorList.Visible = true;
            GBsalesOrderList.Visible = true;
            GBPurchaseOrder.Visible = false;
            GBtruckList.Visible = false;
            GBCustList.Visible = false;
            GBItemList.Visible = false;
        }

        private void btnTruckList_Click(object sender, EventArgs e)
        {
            btnItemList.BackColor = Color.Transparent;
            btncustlist.BackColor = Color.Transparent;
            btnVendorList.BackColor = Color.Transparent;
            btnTruckList.BackColor = Color.LightGray;
            btnSalesOrderList.BackColor = Color.Transparent;
            btnPurchaseOrderList.BackColor = Color.Transparent;

            GBtruckList.Visible = true;
            GBsalesOrderList.Visible = false;
            GBPurchaseOrder.Visible = false;
            GBItemList.Visible = false;
            GBCustList.Visible = false;
            GBvendorList.Visible = false;
        }

        private void btnSalesOrderList_Click(object sender, EventArgs e)
        {
            btnItemList.BackColor = Color.Transparent;
            btncustlist.BackColor = Color.Transparent;
            btnVendorList.BackColor = Color.Transparent;
            btnTruckList.BackColor = Color.Transparent;
            btnSalesOrderList.BackColor = Color.LightGray;
            btnPurchaseOrderList.BackColor = Color.Transparent;

            GBsalesOrderList.Visible = true;
            GBPurchaseOrder.Visible = false;
            GBtruckList.Visible = false;
            GBCustList.Visible = false;
            GBvendorList.Visible = false;
            GBItemList.Visible = false;
        }

        private void btnPurchaseOrderList_Click(object sender, EventArgs e)
        {
            btnItemList.BackColor = Color.Transparent;
            btncustlist.BackColor = Color.Transparent;
            btnVendorList.BackColor = Color.Transparent;
            btnTruckList.BackColor = Color.Transparent;
            btnSalesOrderList.BackColor = Color.Transparent;
            btnPurchaseOrderList.BackColor = Color.LightGray;

            GBPurchaseOrder.Visible = true;
            GBsalesOrderList.Visible = false;
            GBtruckList.Visible = false;
            GBCustList.Visible = false;
            GBvendorList.Visible = false;
            GBItemList.Visible = false;
        }

        private void frm_Inquiryy_Load(object sender, EventArgs e)
        {
            btnItemList.BackColor = Color.LightGray;

            this.Opacity = 0.1;
            timer1.Start();

            timer2.Start();
            label12.Text = DateTime.Now.ToLongDateString();
            label13.Text = DateTime.Now.ToShortTimeString();
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.BackColor = Color.Red;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.BackColor = Color.Transparent;
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
