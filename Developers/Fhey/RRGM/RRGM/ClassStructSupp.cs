using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRGM
{
    class ClassStructSupp
    {
        private string supp_ID, store_name, last_name, first_name, middle_initial, address, phone, fax, email, salesman, payment_term, payment_method, bank_account, credit_limit, open_balance, current_balance;

        public string SUPPID
        {
            get { return supp_ID; }
            set { supp_ID = value; }
        }

        public string STORENAME
        {
            get { return store_name; }
            set { store_name = value; }
        }

        public string LASTNAME
        {
            get { return last_name; }
            set { last_name = value; }
        }

        public string FISTNAME
        {
            get { return first_name; }
            set { first_name = value; }
        }

        public string MIDDLEINITIAL
        {
            get { return middle_initial; }
            set { middle_initial = value; }
        }

        public string ADDRESS
        {
            get { return address; }
            set { address = value; }
        }

        public string PHONE
        {
            get { return phone; }
            set { phone = value; }
        }

        public string FAX
        {
            get { return fax; }
            set { fax = value; }
        }

        public string EMAIL
        {
            get { return email; }
            set { email = value; }
        }

        public string SALEMAN
        {
            get { return salesman; }
            set { salesman = value; }
        }

        public string PAYMENTTERM
        {
            get { return payment_term; }
            set { payment_term = value; }
        }

        public string PAYMENTMETHOD
        {
            get { return payment_method; }
            set { payment_method = value; }
        }

        public string BANKACCOUNT
        {
            get { return bank_account; }
            set { bank_account = value; }
        }

        public string CREDITLIMIT
        {
            get { return credit_limit; }
            set { credit_limit = value; }
        }

        public string OPENBALANCE
        {
            get { return open_balance; }
            set { open_balance = value; }
        }

        public string CURRENTBALANCE
        {
            get { return current_balance; }
            set { current_balance = value; }
        }
    }
}
