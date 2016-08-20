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
    public partial class frmFileMaintenance : Form
    {
        private StructUser structuser = new StructUser();
        private ClassListView listview = new ClassListView();
        private FMuser fmuser = new FMuser();
        private MySqlCommand cmd;
        private MySqlDataReader read;
        public static frmFileMaintenance formFM;

        public frmFileMaintenance()
        {

            InitializeComponent();
            listview.lvwUser(lvwUserList);
            listview.lvwItems(lvwItems);
            ParentFM = false;
            //formFM = this;
        }

        public void RefreshListView()
        {
            listview.lvwUser(lvwUserList);
            listview.lvwItems(lvwItems);
            
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            gbItems.Visible = false;
            gbUser.Visible = true;

        }

        private void btnItems_Click(object sender, EventArgs e)
        {

            gbItems.Visible = true;
            //gbUser.Visible = false;
        }

        private void frmFileMaintenance_Load(object sender, EventArgs e)
        {
            gbItems.Visible = false;
            listview.lvwUser(lvwUserList);

        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {

        }

        private void lvwUserList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (!Connection.IsOpen)
            //    Connection.Open();
            //string select = string.Format("SELECT * from tbluser");
            //cmd = new MySqlCommand(select, Connection.MySqlConnection);
            //read = cmd.ExecuteReader();
            //if (read.Read())
            //{
            //    if (lvwUserList.SelectedItems.Count > 0)
            //    {
           

            //        ListViewItem lv_display = lvwUserList.SelectedItems[0];
            //        update.id = lv_display.SubItems[0].Text;
            //        string password = lv_display.SubItems[1].Text;
            //        string firstname = lv_display.SubItems[2].Text;
            //        string middlename = lv_display.SubItems[3].Text;
            //        string lastname = lv_display.SubItems[4].Text;
            //string position = lv_display.SubItems[5].Text;
            //    }


            //}
            //else
            //    {
            //        MessageBox.Show("No Records found!");
            //    }


            //Connection.Close();

           

        }

        private void txtUpdate_Click(object sender, EventArgs e)
        {
            
            if (lvwUserList.SelectedItems.Count != 0)
            {
                frmUpdateUser update = new frmUpdateUser(this);
                update.id = lvwUserList.SelectedItems[0].Text;
                update.PASSWORD = lvwUserList.SelectedItems[0].SubItems[1].Text;
                update.FIRSTNAME = lvwUserList.SelectedItems[0].SubItems[2].Text;
                update.MIDDLENAME = lvwUserList.SelectedItems[0].SubItems[3].Text;
                update.LASTNAME = lvwUserList.SelectedItems[0].SubItems[4].Text;
                update.POSITION = lvwUserList.SelectedItems[0].SubItems[5].Text;

             update.Show(this);
            }
            else
            {
                MessageBox.Show("No Records found.");
            }
            

        }

        private void frmFileMaintenance_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if(!ParentFM)
            //Application.Exit();
        }
        internal bool ParentFM { get; set; }

        private void gbUser_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUser add = new frmAddUser(this);
            add.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Connection.Open();
            //if (cboSearch.Text == "User ID")
            //{
            //    string search = string.Format("SELECT * FROM tbluser where userID like '" + txtSearch.Text + "%'");
            //    cmd = new MySqlCommand(search, Connection.MySqlConnection);
            //   // read = cmd.ExecuteReader();
            //    MySqlDataAdapter sda = new MySqlDataAdapter();
            //    sda.SelectCommand = cmd;
            //    DataTable dbdataset = new DataTable();
            //    sda.Fill(dbdataset);
                  

            //    for (int i = 0; i < dbdataset.Rows.Count; i++)
            //    {
            //        lvwUserList.Items.Clear();
            //        DataRow dr = dbdataset.Rows[i];
            //        ListViewItem item = new ListViewItem(dr["userID"].ToString());
            //        item.SubItems.Add(dr["password"].ToString());
            //        item.SubItems.Add(dr["firstname"].ToString());
            //        item.SubItems.Add(dr["middlename"].ToString());
            //        item.SubItems.Add(dr["lastname"].ToString());
            //        item.SubItems.Add(dr["position"].ToString());
            //        lvwUserList.Items.Add(item);

            //    }

            //}
            //Connection.Close();

            if (txtSearch.Text != "")
            {
                for (int i = lvwUserList.Items.Count - 1; i >= 0; i--)
                {
                    var item = lvwUserList.Items[i];
                    if (item.Text.ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                    }
                    else
                    {
                        lvwUserList.Items.Remove(item);
                    }
                }
                if (lvwUserList.SelectedItems.Count == 1)
                {
                    lvwUserList.Focus();
                }
            }
            else
            {
                RefreshListView();
            }
        }

        private void lvwItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmAddInv add = new frmAddInv(this);
            add.Show();

        }

        private void btnEdiitems_Click(object sender, EventArgs e)
        {
            if (lvwItems.SelectedItems.Count != 0)
            {
                frmUpdateItems update = new frmUpdateItems(this);
                update.items_id = lvwItems.SelectedItems[0].Text;
                update.description = lvwItems.SelectedItems[0].SubItems[1].Text;
                update.price = lvwItems.SelectedItems[0].SubItems[2].Text;
                update.last_unit_cost = lvwItems.SelectedItems[0].SubItems[3].Text;
                update.item_type = lvwItems.SelectedItems[0].SubItems[4].Text;
                update.location = lvwItems.SelectedItems[0].SubItems[5].Text;
                update.safe_lvl = lvwItems.SelectedItems[0].SubItems[6].Text;
                update.critical_lvl = lvwItems.SelectedItems[0].SubItems[7].Text;
                update.reorder_lvl = lvwItems.SelectedItems[0].SubItems[8].Text;
                update.qty_hand = lvwItems.SelectedItems[0].SubItems[9].Text;
                update.qty_so = lvwItems.SelectedItems[0].SubItems[10].Text;
                update.qty_po = lvwItems.SelectedItems[0].SubItems[11].Text;
                update.supplier_id = lvwItems.SelectedItems[0].SubItems[12].Text;

                update.Show(this);
            }
            else
            {
                MessageBox.Show("No Records found.");
            }
        }
    }
    }

