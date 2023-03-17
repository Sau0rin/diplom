using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    internal class async_recalculation
    {
        recalculation recalculation = new recalculation(); 
       
       public async void refrash()
        {
            try
            {
                Func<Task> testFunc = async () =>
                {

                    string load_main_grid_a = @"SELECT number,date_refrash FROM bux";
                    DB dB_main_grid_a = new DB(); Dictionary<string, int> s = new Dictionary<string, int>(); List<DateTime> list_bux = new List<DateTime>();
                    MySqlCommand mySqlCommand_main_grid_a = new MySqlCommand(load_main_grid_a, dB_main_grid_a.getConnection()); dB_main_grid_a.openConnection();
                    DbDataReader reader = mySqlCommand_main_grid_a.ExecuteReader();
                    while (reader.Read())
                    {
                        list_bux.Add(Convert.ToDateTime(reader[1]));
                        s.Add(Convert.ToString(reader[1]), Convert.ToInt32(reader[0]));

                    }
                    dB_main_grid_a.closeConnection();
                   Console.WriteLine(list_bux.Min());
                    while (DateTime.Now < list_bux.Min())
                    {
                        await Task.Delay(1000);
                    }


                    string select_bux = @"SELECT number,name,cost,quantity,summ,spi,division,date,residual_cost,remains_spi,planned_production,real_production,coefficient,method,date_refrash FROM bux where number=" + "'" + s[list_bux.Min().ToString()] + "'";
                    DB dB_select_bux = new DB();
                    MySqlCommand mySqlCommand_select_bux = new MySqlCommand(select_bux, dB_select_bux.getConnection()); dB_select_bux.openConnection();
                    DbDataReader reader_select_bux = mySqlCommand_select_bux.ExecuteReader(); reader_select_bux.Read();
                    string select_nal = @"SELECT residual_cost,remains_spi,coefficient,standart_amor,method FROM nal where number=" + "'" + s[list_bux.Min().ToString()] + "'";
                    DB dB_select_nal = new DB();
                    MySqlCommand mySqlCommand_select_nal = new MySqlCommand(select_nal, dB_select_nal.getConnection()); dB_select_nal.openConnection();
                    DbDataReader reader_select_nal = mySqlCommand_select_nal.ExecuteReader(); reader_select_nal.Read();
                    string amortization = recalculation.Amortization_bux(Convert.ToDouble(reader_select_bux["residual_cost"]), Convert.ToInt32(reader_select_bux["remains_spi"]), Convert.ToDouble(reader_select_bux["planned_production"]), Convert.ToDouble(reader_select_bux["real_production"]), Convert.ToDouble(reader_select_bux["coefficient"]), reader_select_bux["method"].ToString());
                    string amortization_nal = recalculation.Amortization_nal(Convert.ToDouble(reader_select_nal["residual_cost"]), Convert.ToInt32(reader_select_nal["remains_spi"]), Convert.ToDouble(reader_select_nal["coefficient"]), Convert.ToDouble(reader_select_nal["standart_amor"]), reader_select_nal["method"].ToString());
                    if ((Convert.ToDouble(reader_select_bux["residual_cost"]) == 0 && Convert.ToDouble(reader_select_nal["residual_cost"]) == 0) || (Convert.ToDouble(reader_select_bux["residual_cost"]) < Convert.ToDouble(amortization) && Convert.ToDouble(reader_select_nal["residual_cost"]) < Convert.ToDouble(amortization_nal)))
                    {
                        string write_downs_object = "INSERT INTO write_downs (number,name,cost,quantity,summ,spi,residual_cost,division,date) VALUE " +
                "('" + reader_select_bux["number"].ToString() + "','" + reader_select_bux["name"].ToString() + "','" + reader_select_bux["cost"].ToString() + "','" + reader_select_bux["quantity"].ToString() + "','" + reader_select_bux["summ"].ToString() + "','" + reader_select_bux["spi"].ToString() + "','" + reader_select_bux["residual_cost"].ToString() + "','" + reader_select_bux["division"].ToString() + "','" + reader_select_bux["date"].ToString() + "')";
                        DB dB_write_downs_object = new DB();
                        MySqlCommand mySqlCommand_write_downs_object = new MySqlCommand(write_downs_object, dB_write_downs_object.getConnection()); dB_write_downs_object.openConnection();
                        MySqlDataAdapter adapter_write_downs_object = new MySqlDataAdapter(mySqlCommand_write_downs_object);
                        DataSet dataSet_write_downs_object = new DataSet();
                        adapter_write_downs_object.Fill(dataSet_write_downs_object); dB_write_downs_object.closeConnection();



                        string delite_object = "delete from bux where number=" + "'" + s[list_bux.Min().ToString()] + "'";
                        DB dB_delite_object = new DB();
                        MySqlCommand mySqlCommand_delite_object = new MySqlCommand(delite_object, dB_delite_object.getConnection()); dB_delite_object.openConnection();
                        MySqlDataAdapter adapter_delite_object = new MySqlDataAdapter(mySqlCommand_delite_object);
                        DataSet dataSet_delite_object = new DataSet();
                        adapter_delite_object.Fill(dataSet_delite_object); dB_delite_object.closeConnection();

                        string delite_object_nal = "delete from nal where number=" + "'" + s[list_bux.Min().ToString()] + "'";
                        DB dB_delite_object_nal = new DB();
                        MySqlCommand mySqlCommand_delite_object_nal = new MySqlCommand(delite_object_nal, dB_delite_object_nal.getConnection()); dB_delite_object_nal.openConnection();
                        MySqlDataAdapter adapter_delite_object_nal = new MySqlDataAdapter(mySqlCommand_delite_object_nal);
                        DataSet dataSet_delite_object_nal = new DataSet();
                        adapter_delite_object_nal.Fill(dataSet_delite_object_nal); dB_delite_object_nal.closeConnection();
                    }
                    else
                    {
                        DateTime now = DateTime.Now; DateTime eventDate = DateTime.ParseExact(reader_select_bux["date_refrash"].ToString(), "G", null) + TimeSpan.FromSeconds(30);
                        DB dB_update_bux = new DB();
                        string update_bux = "UPDATE bux SET remains_spi=@remains_spi, amortization=@amortization, residual_cost=@residual_cost, date_update=@date_update, date_refrash = @date_refrash  where number=" + "'" + s[list_bux.Min().ToString()] + "'";
                        MySqlCommand mySqlCommand_update_bux = new MySqlCommand(update_bux, dB_update_bux.getConnection()); dB_update_bux.openConnection();
                        mySqlCommand_update_bux.Parameters.AddWithValue("@remains_spi", (Convert.ToInt32(reader_select_bux["remains_spi"]) - 1).ToString());
                        mySqlCommand_update_bux.Parameters.AddWithValue("@amortization", amortization);
                        mySqlCommand_update_bux.Parameters.AddWithValue("@residual_cost", (Convert.ToDouble(reader_select_bux["residual_cost"]) - Convert.ToDouble(amortization)).ToString());
                        mySqlCommand_update_bux.Parameters.AddWithValue("@date_update", $"{now:G}");
                        mySqlCommand_update_bux.Parameters.AddWithValue("@date_refrash", $"{eventDate:G}");
                        mySqlCommand_update_bux.ExecuteNonQuery();
                        dB_update_bux.closeConnection(); dB_select_bux.closeConnection();



                        DB dB_update_nal = new DB();
                        string update_nal = "UPDATE nal SET remains_spi=@remains_spi, amortization=@amortization, residual_cost=@residual_cost, date_update=@date_update, date_refrash = @date_refrash  where number=" + "'" + s[list_bux.Min().ToString()] + "'";
                        MySqlCommand mySqlCommand_update_nal = new MySqlCommand(update_nal, dB_update_nal.getConnection()); dB_update_nal.openConnection();
                        mySqlCommand_update_nal.Parameters.AddWithValue("@remains_spi", (Convert.ToInt32(reader_select_nal["remains_spi"]) - 1).ToString());
                        mySqlCommand_update_nal.Parameters.AddWithValue("@amortization", amortization_nal);
                        mySqlCommand_update_nal.Parameters.AddWithValue("@residual_cost", (Convert.ToDouble(reader_select_nal["residual_cost"]) - Convert.ToDouble(amortization_nal)).ToString());
                        mySqlCommand_update_nal.Parameters.AddWithValue("@date_update", $"{now:G}");
                        mySqlCommand_update_nal.Parameters.AddWithValue("@date_refrash", $"{eventDate:G}");
                        mySqlCommand_update_nal.ExecuteNonQuery();
                        dB_update_nal.closeConnection(); dB_select_nal.closeConnection();
                    }



                };
                while (true)
                {
                    await testFunc();
                }
            }
            catch
            {
                MessageBox.Show("Всё оборудование списано");
            }
        }
    }
}
