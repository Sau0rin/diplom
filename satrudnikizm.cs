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
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
   
    public partial class satrudnikizm : Form
    {
        Form1 form13;
        public satrudnikizm(Form1 dva)
        {
            form13 = dva;
            InitializeComponent();
        }

        private void satrudnikizm_Load(object sender, EventArgs e)
        {
            string us = "Select * From otdel";
           
            DB dt = new DB();

            MySqlCommand cm = new MySqlCommand(us, dt.getConnection());
            dt.openConnection();

            DbDataReader reader = cm.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add((string)reader["Название_отдела"]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (MySqlConnection cn = new MySqlConnection("SERVER=remotemysql.com;" + "DATABASE=jyJu95JBqz;" + "UID= jyJu95JBqz;" + "Pwd=8xKQSi58g9;"))
            {
                try
                {
                    cn.Open();
                    string strUpd = "UPDATE otvetstvenai SET  Имя=@Имя,Фамилия=@Фамилия,Отчество=@Отчество,Табельный_номер=@Табельный_номер,Отдел=@Отдел,Дата_рождение=@Дата_рождение,Пол=@Пол,prava=@prava where Табельный_номер =" + "'" + textBox5.Text + "'";
                    MySqlCommand cmdUpd = new MySqlCommand(strUpd, cn);
                    
             
                    cmdUpd.Parameters.AddWithValue("@Имя", textBox2.Text);
                    cmdUpd.Parameters.AddWithValue("@Фамилия", textBox3.Text);
                    cmdUpd.Parameters.AddWithValue("@Отчество", textBox4.Text);
                    cmdUpd.Parameters.AddWithValue("@Табельный_номер", textBox5.Text);
                    cmdUpd.Parameters.AddWithValue("@Отдел", comboBox1.Text);
                    cmdUpd.Parameters.AddWithValue("@Дата_рождение", dateTimePicker1.Text);
                    if (male.Checked)
                        cmdUpd.Parameters.AddWithValue("@Пол","М");
                    if (female.Checked)
                        cmdUpd.Parameters.AddWithValue("@Пол", "Ж");
                    if (admin.Checked)
                        cmdUpd.Parameters.AddWithValue("@prava", "admin");
                    if (user.Checked)
                        cmdUpd.Parameters.AddWithValue("@prava", "user");
                    int res = cmdUpd.ExecuteNonQuery();
                    cn.Close();

                string qwer = @"SELECT ID,Фамилия,Имя,Отчество,Табельный_номер,Отдел,Дата_рождение,Пол FROM otvetstvenai";

                DB dtt = new DB();

                MySqlCommand cmd = new MySqlCommand(qwer, dtt.getConnection());
                MySqlDataAdapter nett = new MySqlDataAdapter(cmd);
                DataSet dss = new DataSet();
                nett.Fill(dss);
                form13.dataGridView2.DataSource = dss.Tables[0].DefaultView;

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofp = new OpenFileDialog();
            ofp.Filter = "Image files (*.BMP;*.JPG;*GIF;*.PNG) |*.BMP;*.JPG;*GIF;*.PNG| All files (*.*)|*.*";
            if (ofp.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(ofp.FileName);

                }
                catch
                {
                    MessageBox.Show("Не верный формат файла"); 
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        { string add = "";
            if (admin.Checked)
            {
                if (male.Checked)
                    add = @"INSERT INTO otvetstvenai (Имя,Фамилия,Отчество,Табельный_номер,Отдел,Дата_рождение,Пол,login,password,prava) VALUE ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + dateTimePicker1.Text + "','" + "М" + "','" + textBox1.Text + "','" + textBox6.Text + "','" + "admin" + "')";
                if (female.Checked)
                    add = @"INSERT INTO otvetstvenai (Имя,Фамилия,Отчество,Табельный_номер,Отдел,Дата_рождение,Пол,login,password,prava) VALUE ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + dateTimePicker1.Text + "','" + "Ж" + "','" + textBox1.Text + "','" + textBox6.Text + "','" + "admin" + "')";
            }
            if (user.Checked)
            {
                if (male.Checked)
                    add = @"INSERT INTO otvetstvenai (Имя,Фамилия,Отчество,Табельный_номер,Отдел,Дата_рождение,Пол,login,password,prava) VALUE ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + dateTimePicker1.Text + "','" + "М" + "','" + textBox1.Text + "','" + textBox6.Text + "','" + "user" + "')";
                if (female.Checked)
                    add = @"INSERT INTO otvetstvenai (Имя,Фамилия,Отчество,Табельный_номер,Отдел,Дата_рождение,Пол,login,password,prava) VALUE ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + dateTimePicker1.Text + "','" + "Ж" + "','" + textBox1.Text + "','" + textBox6.Text + "','" + "user" + "')";
            }

            DB dt = new DB();

            MySqlCommand cm = new MySqlCommand(add, dt.getConnection());
            MySqlDataAdapter net = new MySqlDataAdapter(cm);
            DataSet ds = new DataSet();
            net.Fill(ds); dt.closeConnection();

            string qwer = @"SELECT ID,Фамилия,Имя,Отчество,Табельный_номер,Отдел,Дата_рождение,Пол FROM otvetstvenai";

            DB dtt = new DB();

            MySqlCommand cmd = new MySqlCommand(qwer, dtt.getConnection());
            MySqlDataAdapter nett = new MySqlDataAdapter(cmd);
            DataSet dss = new DataSet();
            nett.Fill(dss);
            form13.dataGridView2.DataSource = dss.Tables[0].DefaultView;
        }
    }
}
