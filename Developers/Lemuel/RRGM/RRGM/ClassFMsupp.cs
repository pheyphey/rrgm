using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace RRGM
{
    class ClassFMsupp
    {
        private MySqlCommand cmd;
        private MySqlDataReader read;
        ClassStructSupp _structSupp = new ClassStructSupp();

        public void Retrieve(string id)
        {
            if (!Connection.IsOpen)
                Connection.Open();
            string select = string.Format("SELECT * FROM tbl_supplier where supplier_ID='{0}' ", id);
            cmd = new MySqlCommand(select, Connection.MySqlConnection);
            read = cmd.ExecuteReader();
            if (read.HasRows)
                while (read.Read())
                {
                    _structSupp.SUPPID = read.GetValue(0).ToString();
                    _structSupp.STORENAME = read.GetValue(1).ToString();
                    _structSupp.LASTNAME = read.GetValue(2).ToString();
                    _structSupp.FISTNAME = read.GetValue(3).ToString();
                    _structSupp.MIDDLEINITIAL = read.GetValue(4).ToString();
                    _structSupp.ADDRESS = read.GetValue(5).ToString();
                    _structSupp.PHONE = read.GetValue(6).ToString();
                    _structSupp.FAX = read.GetValue(7).ToString();
                    _structSupp.EMAIL = read.GetValue(8).ToString();
                    _structSupp.SALEMAN = read.GetValue(9).ToString();
                    _structSupp.PAYMENTTERM = read.GetValue(10).ToString();
                    _structSupp.PAYMENTMETHOD = read.GetValue(11).ToString();
                    _structSupp.BANKACCOUNT = read.GetValue(12).ToString();
                    _structSupp.CREDITLIMIT = read.GetValue(13).ToString();
                    _structSupp.OPENBALANCE = read.GetValue(14).ToString();
                    _structSupp.CURRENTBALANCE = read.GetValue(15).ToString();
                }
            _structSupp.SUPPID = id;
            Connection.Close();
        }

        public void Update(ClassStructSupp supp)
        {
            Connection.Open();
            string update = string.Format("UPDATE tbl_supplier SET store_name='{1}',  last_name='{2}',  first_name='{3}',  middle_initial='{4}',  address='{5}',  phone='{6}',  fax='{7}',  email='{8}', salesman='{9}',  payment_term='{10}',  payment_method='{11}',  bank_account='{12}',  credit_limit='{13}',  open_balance='{14}',  current_balance='{15}' WHERE supplier_ID='{0}'",
                supp.SUPPID, supp.STORENAME, supp.LASTNAME, supp.FISTNAME, supp.MIDDLEINITIAL, supp.ADDRESS, supp.PHONE, supp.FAX, supp.EMAIL, supp.SALEMAN, supp.PAYMENTTERM, supp.PAYMENTMETHOD, supp.BANKACCOUNT, supp.CREDITLIMIT, supp.OPENBALANCE, supp.CURRENTBALANCE);
            cmd = new MySqlCommand(update, Connection.MySqlConnection);
            read = cmd.ExecuteReader();
            MessageBox.Show("Saved!");

            Connection.Close();
        }

        public void add(ClassStructSupp supp)
        {
            Connection.Open();
            string insert = string.Format("INSERT tbl_supplier SET supplier_ID='{0}', store_name='{1}',  last_name='{2}',  first_name='{3}',  middle_initial='{4}',  address='{5}',  phone='{6}',  fax='{7}',  email='{8}', salesman='{9}',  payment_term='{10}',  payment_method='{11}',  bank_account='{12}',  credit_limit='{13}',  open_balance='{14}',  current_balance='{15}'",
                 supp.SUPPID, supp.STORENAME, supp.LASTNAME, supp.FISTNAME, supp.MIDDLEINITIAL, supp.ADDRESS, supp.PHONE, supp.FAX, supp.EMAIL, supp.SALEMAN, supp.PAYMENTTERM, supp.PAYMENTMETHOD, supp.BANKACCOUNT, supp.CREDITLIMIT, supp.OPENBALANCE, supp.CURRENTBALANCE);
            cmd = new MySqlCommand(insert, Connection.MySqlConnection);
            read = cmd.ExecuteReader();
            MessageBox.Show("Saved!");

            Connection.Close();
        }
    }
}
