using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class update
    {
        public string update_date ()
        {
            string[] vs = new string[2];
            string update = "select date_update from bux";
            DB dt = new DB();
            MySqlCommand command = new MySqlCommand(update, dt.getConnection());
            dt.openConnection();
            DbDataReader reader = command.ExecuteReader();
            List<string> list_bux = new List<string>();
            while (reader.Read())
            {
                list_bux.Add((string)reader[0]);
            }
            vs[0] = list_bux.Max();
            dt.closeConnection();

            string update_nal = "select date_update from nal"; 
            DB dt_nal = new DB();
            MySqlCommand command_nal = new MySqlCommand(update_nal, dt_nal.getConnection());
            dt_nal.openConnection();
            DbDataReader reader_nal = command_nal.ExecuteReader();
            List<string> list_nal = new List<string>();
            while (reader_nal.Read())
            {
                list_nal.Add((string)reader_nal[0]);
                
            }
            vs[1]= list_nal.Max();
            dt_nal.closeConnection();
            return vs.Max();
        }
    }
}
