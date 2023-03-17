using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    class DB
    {
       
        MySqlConnection conn = new MySqlConnection("SERVER=q77985ht.beget.tech;" + "DATABASE=q77985ht_osn;" + "UID=q77985ht_osn;" + "Pwd=v2WN8wxe@gRd%h5;");

        public void openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
        }
        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }

        public MySqlConnection getConnection()
        {
            return conn;
        }
    }
}
