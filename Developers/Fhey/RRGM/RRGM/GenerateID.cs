using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RRGM
{
    class GenerateID
    {
        private MySqlCommand cmd;
        private MySqlDataReader read;
        private string query;
        private string sID;
        private string newID;
        private int iID;

        private string _id;

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        //PAG GAWA NG ID!
        public void setID(string column, string table, string hypen, int subStringNum)
        {
            try
            {
                if (!Connection.IsOpen)
                    Connection.Open();
                query = string.Format("SELECT {0} FROM {1} ORDER BY {0} DESC LIMIT 1", column, table);
                cmd = new MySqlCommand(query, Connection.MySqlConnection);
                sID = cmd.ExecuteScalar().ToString();
                sID = sID.Substring(subStringNum, 4).ToString();
            }
            finally
            {
                iID = int.Parse(sID) + 1;
                newID = iID.ToString();

                for (int i = 0; i < 4 - iID.ToString().Length; i++)
                    newID = string.Format("{0}{1}", "0", newID);
                newID = hypen + newID;
                this.ID = newID;

                Connection.Close();
            }
        }
    }
}
