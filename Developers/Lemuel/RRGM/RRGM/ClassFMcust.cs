using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace RRGM
{
    class ClassFMcust
    {
        private MySqlCommand cmd;
        private MySqlDataReader read;
        ClassStructCust _structCust = new ClassStructCust();

        public void Retrieve(string id)
        {
            if (!Connection.IsOpen)
                Connection.Open();
            string select = string.Format("SELECT * FROM tbl_cust where cust_ID='{0}' ", id);
            cmd = new MySqlCommand(select, Connection.MySqlConnection);
            read = cmd.ExecuteReader();
            if (read.HasRows)
                while (read.Read())
                {
                    _structCust.CUSTID = read.GetValue(0).ToString();
                    _structCust.STORENAME = read.GetValue(1).ToString();
                    _structCust.LASTNAME = read.GetValue(2).ToString();
                    _structCust.FISTNAME = read.GetValue(3).ToString();
                    _structCust.MIDDLEINITIAL = read.GetValue(4).ToString();
                    _structCust.ADDRESS = read.GetValue(5).ToString();
                    _structCust.PHONE = read.GetValue(6).ToString();
                    _structCust.FAX = read.GetValue(7).ToString();
                    _structCust.EMAIL = read.GetValue(8).ToString();
                    _structCust.SALEMAN = read.GetValue(9).ToString();
                    _structCust.PAYMENTTERM = read.GetValue(10).ToString();
                    _structCust.PAYMENTMETHOD = read.GetValue(11).ToString();
                    _structCust.BANKACCOUNT = read.GetValue(12).ToString();
                    _structCust.CREDITLIMIT = read.GetValue(13).ToString();
                    _structCust.OPENBALANCE = read.GetValue(14).ToString();
                    _structCust.CURRENTBALANCE = read.GetValue(15).ToString();
                }
            _structCust.CUSTID = id;
            Connection.Close();
        }

        public void Update(ClassStructCust cust)
        {
            Connection.Open();
            string update = string.Format("UPDATE tbl_cust SET store_name='{1}',  last_name='{2}',  first_name='{3}',  middle_initial='{4}',  address='{5}',  phone='{6}',  fax='{7}',  email='{8}', salesman='{9}',  payment_term='{10}',  payment_method='{11}',  bank_account='{12}',  credit_limit='{13}',  open_balance='{14}',  current_balance='{15}' WHERE cust_id='{0}'" ,
                cust.CUSTID, cust.STORENAME, cust.LASTNAME, cust.FISTNAME, cust.MIDDLEINITIAL, cust.ADDRESS, cust.PHONE, cust.FAX, cust.EMAIL, cust.SALEMAN, cust.PAYMENTTERM, cust.PAYMENTMETHOD, cust.BANKACCOUNT, cust.CREDITLIMIT, cust.OPENBALANCE, cust.CURRENTBALANCE);
            cmd = new MySqlCommand(update, Connection.MySqlConnection);
            read = cmd.ExecuteReader();
            MessageBox.Show("Saved!");

            Connection.Close();
        }

        public void add(ClassStructCust cust)
        {
            Connection.Open();
            string insert = string.Format("INSERT tbl_cust SET cust_id='{0}', store_name='{1}',  last_name='{2}',  first_name='{3}',  middle_initial='{4}',  address='{5}',  phone='{6}',  fax='{7}',  email='{8}', salesman='{9}',  payment_term='{10}',  payment_method='{11}',  bank_account='{12}',  credit_limit='{13}',  open_balance='{14}',  current_balance='{15}'",
                 cust.CUSTID, cust.STORENAME, cust.LASTNAME, cust.FISTNAME, cust.MIDDLEINITIAL, cust.ADDRESS, cust.PHONE, cust.FAX, cust.EMAIL, cust.SALEMAN, cust.PAYMENTTERM, cust.PAYMENTMETHOD, cust.BANKACCOUNT, cust.CREDITLIMIT, cust.OPENBALANCE, cust.CURRENTBALANCE);
            cmd = new MySqlCommand(insert, Connection.MySqlConnection);
            read = cmd.ExecuteReader();
            MessageBox.Show("Saved!");

            Connection.Close();
        }
    }
}
