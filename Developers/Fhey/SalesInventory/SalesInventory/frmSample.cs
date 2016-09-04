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
    public partial class frmSample : Form
    {
        ClassListView listview = new ClassListView();
        public frmSample()
        {
            InitializeComponent();
            listview.lvwTransaction_Cust(lvwCust);
        }



        private void frmSample_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(500,120);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvwCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lvwCust.SelectedItems.Count != 0)
            //{
            //    frmSalesTrans sales = new frmSalesTrans();
            //    ListViewItem item = lvwCust.SelectedItems[0];
            //    sales.CUST_ID = item.SubItems[0].Text;
            //    sales.CUST_Name = item.SubItems[1].Text;

            //    this.Close();

            //}
         }
    }
}
