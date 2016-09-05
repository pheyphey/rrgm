using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesInventory
{
    class StructUser
    {
        private string userid, password, firstname, lastname, middlename, position;

        public string USERID
        {
            get { return userid; }
            set { userid = value; }
        }

        public string PASSWORD
        {
            get { return password; }
            set { password = value; }
        }

        public string FIRSTNAME
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string MIDDLENAME
        {
            get { return middlename; }
            set { middlename = value; }
        }

        public string LASTNAME
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string POSITION
        {
            get { return position; }
            set { position = value; }
        }
    }
}
