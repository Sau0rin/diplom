﻿using MySql.Data.MySqlClient;
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

namespace WindowsFormsApp1
{
    public partial class Nalog_editing_equipment : Form
    {
        public Nalog_editing_equipment()
        {
            InitializeComponent();
        }

        private void update_nal_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DB dB_update_nal = new DB();
            string update_bux = "UPDATE nal SET am_group=@am_group, division=@division, standart_amor=@standart_amor, real_cost=@real_cost,date_update=@date_update where number=" + "'" + number.Text + "'";
            MySqlCommand mySqlCommand_update_nal = new MySqlCommand(update_bux, dB_update_nal.getConnection()); dB_update_nal.openConnection();
            mySqlCommand_update_nal.Parameters.AddWithValue("@am_group", am_group.Text);
            mySqlCommand_update_nal.Parameters.AddWithValue("@division", division.Text);
            mySqlCommand_update_nal.Parameters.AddWithValue("@standart_amor", standart_amor.Text);
            mySqlCommand_update_nal.Parameters.AddWithValue("@real_cost", real_cost.Text);
            mySqlCommand_update_nal.Parameters.AddWithValue("@date_update", $"{now:G}");
            mySqlCommand_update_nal.ExecuteNonQuery();
            dB_update_nal.closeConnection();
        }

        private void Nalog_editing_equipment_Load(object sender, EventArgs e)
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
    }
}
