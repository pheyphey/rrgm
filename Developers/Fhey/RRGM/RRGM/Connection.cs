using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;



namespace RRGM
{
    class Connection
    {
        private static MySqlConnection connection;
        internal static string _username = "root";
        internal static string _password = "admin";
        internal static string _dbname = "dbrrgm";
        internal static string _conn;

        static Connection()
        {
            _conn = string.Format("server=localhost;database={0};uid={1};password={2}", _dbname, _username, _password);
            connection = new MySqlConnection(_conn);
        }
        internal static MySqlConnection MySqlConnection
        {
            get { return connection; }

        }
        internal static void Close()
        {
            connection.Close();
        }
        internal static void Open()
        {
            try
            {
                connection.Open();

            }
            catch (MySqlException)
            {
                MessageBox.Show("Can't open", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        internal static bool IsOpen
        {
            get
            {
                return MySqlConnection.State == System.Data.ConnectionState.Open;
            }
        }
    }
}

