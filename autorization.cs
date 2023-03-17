using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class authorization : Form
    {
        public authorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim() == "" && textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Введите логин или пароль");
            }
            else
            {
                string auth = @"SELECT login,password,prava FROM otvetstvenai WHERE login = " + "'" + comboBox1.Text + "'" + "and password =" + "'" + textBox1.Text + "'" ;
                DB dttt = new DB();
                MySqlCommand cmdd = new MySqlCommand(auth, dttt.getConnection()); dttt.openConnection();
                MySqlDataAdapter da = new MySqlDataAdapter(cmdd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DbDataReader rea = cmdd.ExecuteReader();
                rea.Read();
                if (dt.Rows.Count > 0)
                {
                    if (rea[2].ToString() == "user")
                    {
                        Form1 form1 = new Form1(this);
                        form1.Show();
                        this.Hide();
                        form1.tabControl1.Enabled = false;
                    }
                    else 
                    {
                        Form1 form1 = new Form1(this);
                        form1.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Не верный логин или пароль");
                }
                dttt.closeConnection();
            }
        }

        private void authorization_Load(object sender, EventArgs e)
        {
            string us = "select login from otvetstvenai";

            DB dt = new DB();

            MySqlCommand cm = new MySqlCommand(us, dt.getConnection());
            dt.openConnection();
            DbDataReader reader = cm.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add((string)reader[0]);
            }
            dt.closeConnection();
        }

    }
}
