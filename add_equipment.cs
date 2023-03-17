using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class add_equipment : Form
    {   
        public add_equipment()
        {
            
            InitializeComponent(); 
        }


        private string Amortization_bux()
        {
            if (linear_bux.Checked)
            {
                return "linear_bux";

            }
            else if (remains.Checked)
            {
                return "remains";
            }
            else if (write_downs.Checked)
            {
                return "write_downs";
            }
            return "error";
        }
        private string Amortization_nal()
        {
            if (linear_nal.Checked)
            {
                return "linear_nal";
            }
            else if (non_linear_nal.Checked)
            {
                return "non_linear_nal";
            }
            return "error";
        }

        private void save_Click(object sender, EventArgs e)
        {
           
            
            DateTime now = DateTime.Now;
            DateTime eventDate = now + TimeSpan.FromSeconds(10);
            //calculation calculation = new calculation();
            //string amor_bux = calculation.Amortization_bux(Convert.ToDouble(quantity.Text), Convert.ToDouble(cost.Text), Convert.ToInt32(spi.Text), Convert.ToDouble(liquidated_cost.Text), Convert.ToDouble(planned_production.Text), Convert.ToDouble(real_production.Text), Convert.ToDouble(coefficient_bux.Text),Amortization_bux());
            //string residual_bux = (Convert.ToDouble(quantity.Text) * (Convert.ToDouble(cost.Text) - Convert.ToDouble(liquidated_cost.Text)) - Convert.ToDouble(amor_bux)).ToString();
            //string amor_nal = calculation.Amortization_nal(Convert.ToDouble(quantity.Text), (Convert.ToDouble(cost.Text) * (1 - (Convert.ToDouble(prize_amor.Text) * 0.01))), Convert.ToInt32(spi.Text), Convert.ToDouble(coefficient_nal.Text), Convert.ToDouble(standart_amor.Text),Amortization_nal());
            //string residual_nal = ((Convert.ToDouble(quantity.Text) * Convert.ToDouble(cost.Text) * (1 - (Convert.ToDouble(prize_amor.Text) * 0.01))) - Convert.ToDouble(amor_nal)).ToString();
            DB dB_bux = new DB();
            string add_bux = "INSERT INTO bux (number,name,cost,quantity,summ,spi,remains_spi,am_group,division,date,liquidated_cost,planned_production,real_production,coefficient,residual_cost,method,date_update,date_refrash) VALUE " +
                "('" + number.Text + "','" + name.Text + "','" + cost.Text + "','" + quantity.Text + "','" + Convert.ToDouble(cost.Text) * Convert.ToDouble(quantity.Text) + "','" + spi.Text + "','" + spi.Text + "','" + am_group.Text + "','" + division.Text + "','" + date.Text + "','" + liquidated_cost.Text + "','" + planned_production.Text + "','" + real_production.Text + "','" + coefficient_bux.Text + "','" + (Convert.ToDouble(cost.Text) - Convert.ToDouble(liquidated_cost.Text)) + "','" + Amortization_bux()+ "','" + $"{now:G}" + "','" + eventDate + "')"; 
            string add_nal = "INSERT INTO nal (number,name,cost,quantity,summ,spi,remains_spi,am_group,division,date,coefficient,standart_amor,prize_amor,residual_cost,method,date_update,date_refrash) VALUE " +
                "('" + number.Text + "','" + name.Text + "','" + cost.Text + "','" + quantity.Text + "','" +Convert.ToDouble(cost.Text)* Convert.ToDouble(quantity.Text) + "','" + spi.Text + "','" + spi.Text + "','" + am_group.Text + "','" + division.Text + "','" + date.Text + "','" + coefficient_nal.Text + "','" + standart_amor.Text + "','" + prize_amor.Text + "','" + (Convert.ToDouble(cost.Text) * (1 - (Convert.ToDouble(prize_amor.Text) * 0.01))) + "','" + Amortization_nal() + "','" + $"{now:G}" + "','" + eventDate + "')";
            MySqlCommand mySqlCommand_bux = new MySqlCommand(add_bux, dB_bux.getConnection()); dB_bux.openConnection();
            MySqlDataAdapter mySqlDataAdapter_bux = new MySqlDataAdapter(mySqlCommand_bux);
            DataSet dataSet_bux = new DataSet();
            mySqlDataAdapter_bux.Fill(dataSet_bux);dB_bux.closeConnection();
            DB dB_nal = new DB();
            MySqlCommand mySqlCommand_nal = new MySqlCommand(add_nal, dB_nal.getConnection()); dB_nal.openConnection();
            MySqlDataAdapter mySqlDataAdapter_nal = new MySqlDataAdapter(mySqlCommand_nal);
            DataSet dataSet_nal = new DataSet();
            mySqlDataAdapter_nal.Fill(dataSet_nal); dB_nal.closeConnection();
            
          

        }

        private void add_equipment_Load(object sender, EventArgs e)
        {

            DB dB_division = new DB();
            string load_division = "Select * From  otdel";
            MySqlCommand mySqlCommand_division = new MySqlCommand(load_division, dB_division.getConnection()); dB_division.openConnection();
            DbDataReader dbDataReader_division = mySqlCommand_division.ExecuteReader();
            while (dbDataReader_division.Read())
            {
                division.Items.Add((string)dbDataReader_division["Название_отдела"]);
            }
            dB_division.closeConnection();

        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            if (name.Text ==Regex.Match(name.Text, @"(^\S+)").ToString())
            {
                Dictionary_am_group dictionary_Am_Group = new Dictionary_am_group();
                am_group.Text = dictionary_Am_Group.dictionary(name.Text);

            }

        }

        private void am_group_TextChanged(object sender, EventArgs e)
        {
            if (am_group.Text != "")
            {
                Dictionary_am_group dictionary_Am_Group = new Dictionary_am_group();
                standart_amor.Text = dictionary_Am_Group.norma_amor(am_group.Text);
            }
        }

        private void dictionary_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
