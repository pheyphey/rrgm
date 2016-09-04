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
    public partial class frmEditInv : Form
    {
        private ClassStructItems structITEM = new ClassStructItems();
        private ClassFMitems fmsupp = new ClassFMitems();
        frm_FileMaintenance lvwrefresh = null;
        public frmEditInv(frm_FileMaintenance listview)
        {
            InitializeComponent();
            lvwrefresh = listview;
        }

        public string id
        {
            set { txtItemID.Text = value; }
        }

        public string DESCRIPTION
        {
            set { txtDescription.Text = value; }
        }

        public string PRICE
        {
            set { txtPrice.Text = value; }
        }

        public string LASTUNITCOST
        {
            set { txtLastUnitCost.Text = value; }
        }

        public string ITEMTYPE
        {
            set { txtItemType.Text = value; }
        }

        public string LOCATION
        {
            set { txtLocation.Text = value; }
        }

        public string SAFELEVEL
        {
            set { txtsafelvl.Text = value; }
        }

        public string CRITICALLEVEL
        {
            set { txtCriticallvl.Text = value; }
        }

        public string REORDERLEVEL
        {
            set { txtReorderlvl.Text = value; }
        }

        public string QTYHAND
        {
            set { txtQtyOnHand.Text = value; }
        }

        public string QTYSO
        {
            set { txtQtyOnSO.Text = value; }
        }

        public string QTYPO
        {
            set { txtQtyOnPO.Text = value; }
        }

        public string SUPPLIERID
        {
            set { txtPrefVendorID.Text = value; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            structITEM.ITEMID = txtItemID.Text;
            structITEM.DESCRIPTION = txtDescription.Text;
            structITEM.PRICE = txtPrice.Text;
            structITEM.LASTCOSTUNIT = txtLastUnitCost.Text;
            structITEM.ITEMTYPE = txtItemType.Text;
            structITEM.LOCATION = txtLocation.Text;
            structITEM.SAFELEVEL = txtsafelvl.Text;
            structITEM.CRITICALLEVEL = txtCriticallvl.Text;
            structITEM.REORDERLEVEL = txtReorderlvl.Text;
            structITEM.QTYHAND = txtQtyOnHand.Text;
            structITEM.QTYSO = txtQtyOnSO.Text;
            structITEM.QTYPO = txtQtyOnPO.Text;
            structITEM.SUPPLIERID = txtPrefVendorID.Text;
            fmsupp.Update(structITEM);

            lvwrefresh.RefreshUserListView();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += .05;
            if (this.Opacity == 1)
            {
                timer1.Stop();
            }
        }

        private void frmEditInv_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            timer1.Start();
        }
    }
}
