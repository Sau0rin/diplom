using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        internal string sq = "";
        authorization authoriz;
        public Form1(authorization autoraz)
        {
            authoriz = autoraz;
            InitializeComponent();
        }


        internal void Form1_Load(object sender, EventArgs e)
        {
            main_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            main_grid_nal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grid_write_downs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            sq = authoriz.comboBox1.Text;
            string load_main_grid = @"SELECT number,name,cost,quantity,summ,real_cost,spi,am_group,division,date,amortization,residual_cost,date_refrash FROM bux";
            DB dB_main_grid = new DB();
            MySqlCommand mySqlCommand_main_grid = new MySqlCommand(load_main_grid, dB_main_grid.getConnection());dB_main_grid.openConnection();
            MySqlDataAdapter mySqlDataAdapter_main_grid = new MySqlDataAdapter(mySqlCommand_main_grid);
            DataSet dataSet_main_grid = new DataSet();
            mySqlDataAdapter_main_grid.Fill(dataSet_main_grid);
            main_grid.DataSource = dataSet_main_grid.Tables[0].DefaultView;
            dB_main_grid.closeConnection();


            string load_main_grid_nal = @"SELECT number,name,cost,quantity,summ,real_cost,spi,am_group,division,date,amortization,residual_cost FROM nal";
            DB dB_main_grid_nal = new DB();
            MySqlCommand mySqlCommand_main_grid_nal = new MySqlCommand(load_main_grid_nal, dB_main_grid_nal.getConnection()); dB_main_grid_nal.openConnection();
            MySqlDataAdapter mySqlDataAdapter_main_grid_nal = new MySqlDataAdapter(mySqlCommand_main_grid_nal);
            DataSet dataSet_main_grid_nal = new DataSet();
            mySqlDataAdapter_main_grid_nal.Fill(dataSet_main_grid_nal);
            main_grid_nal.DataSource = dataSet_main_grid_nal.Tables[0].DefaultView;
            dB_main_grid_nal.closeConnection();


            string load_write_downs = @"SELECT number,name,cost,quantity,summ,spi,residual_cost,division,date FROM write_downs";
            DB dB_write_downs = new DB();
            MySqlCommand mySqlCommand_write_downs = new MySqlCommand(load_write_downs, dB_write_downs.getConnection()); dB_write_downs.openConnection();
            MySqlDataAdapter mySqlDataAdapter_write_downs = new MySqlDataAdapter(mySqlCommand_write_downs);
            DataSet dataSet_write_downs = new DataSet();
            mySqlDataAdapter_write_downs.Fill(dataSet_write_downs);
            grid_write_downs.DataSource = dataSet_write_downs.Tables[0].DefaultView;
            dB_write_downs.closeConnection();

            string qwer = @"SELECT ID,Фамилия,Имя,Отчество,Табельный_номер,Отдел,Дата_рождение,Пол FROM otvetstvenai";

            DB dtt = new DB();

            MySqlCommand cmd = new MySqlCommand(qwer, dtt.getConnection());
            MySqlDataAdapter nett = new MySqlDataAdapter(cmd);
            DataSet dss = new DataSet();
            nett.Fill(dss);
            dataGridView2.DataSource = dss.Tables[0].DefaultView;
            dtt.closeConnection();


            string qwert = @"SELECT * FROM otchet";

            DB dttt = new DB();

            MySqlCommand cmdd = new MySqlCommand(qwert, dttt.getConnection());
            MySqlDataAdapter nettt = new MySqlDataAdapter(cmdd);
            DataSet dsss = new DataSet();
            nettt.Fill(dsss);
            dataGridView4.DataSource = dsss.Tables[0].DefaultView;
            dttt.closeConnection();

            string otdel = @"SELECT * FROM otdel";

            DB DB_otdel = new DB();

            MySqlCommand Com_otdel = new MySqlCommand(otdel, DB_otdel.getConnection());
            MySqlDataAdapter Adap_otdel = new MySqlDataAdapter(Com_otdel);
            DataSet Set_otdel = new DataSet();
            Adap_otdel.Fill(Set_otdel);
            dataGridView5.DataSource = Set_otdel.Tables[0].DefaultView;
            DB_otdel.closeConnection();

            update update = new update(); async_recalculation async_Recalculation = new async_recalculation();
            string load_last_date = update.update_date();int i = 0;
            string async_last_date;
            async void GetDv()
            {
                Func<Task> testFunc = async () =>
                {
                    if (main_grid.Rows.Count != 0 && i == 0) { i = 1; async_Recalculation.refrash();  }
                    update update_asy = new update();
                    async_last_date = update_asy.update_date();
                    if (load_last_date != async_last_date)
                    {
                        load_last_date = async_last_date;

                        string load_main_grid_a = @"SELECT number,name,cost,quantity,summ,real_cost,spi,am_group,division,date,amortization,residual_cost,date_refrash FROM bux";

                        DB dB_main_grid_a = new DB();

                        MySqlCommand mySqlCommand_main_grid_a = new MySqlCommand(load_main_grid_a, dB_main_grid_a.getConnection()); dB_main_grid_a.openConnection();
                        MySqlDataAdapter mySqlDataAdapter_main_grid_a = new MySqlDataAdapter(mySqlCommand_main_grid_a);
                        DataSet dataSet_main_grid_a = new DataSet();
                        mySqlDataAdapter_main_grid_a.Fill(dataSet_main_grid_a);
                        main_grid.DataSource = dataSet_main_grid_a.Tables[0].DefaultView;
                        dB_main_grid_a.closeConnection();

                        string load_main_grid_nal_a = @"SELECT number,name,cost,quantity,summ,real_cost,spi,am_group,division,date,amortization,residual_cost,date_refrash FROM nal";

                        DB dB_main_grid_nal_a = new DB();

                        MySqlCommand mySqlCommand_main_grid_nal_a = new MySqlCommand(load_main_grid_nal_a, dB_main_grid_nal_a.getConnection()); dB_main_grid_nal_a.openConnection();
                        MySqlDataAdapter mySqlDataAdapter_main_grid_nal_a = new MySqlDataAdapter(mySqlCommand_main_grid_nal_a);
                        DataSet dataSet_main_grid_nal_a = new DataSet();
                        mySqlDataAdapter_main_grid_nal_a.Fill(dataSet_main_grid_nal_a);
                        main_grid_nal.DataSource = dataSet_main_grid_nal_a.Tables[0].DefaultView;
                        dB_main_grid_nal_a.closeConnection();


                        string load_write_downs_a = @"SELECT number,name,cost,quantity,summ,spi,residual_cost,division,date FROM write_downs";
                        DB dB_write_downs_a = new DB();
                        MySqlCommand mySqlCommand_write_downs_a = new MySqlCommand(load_write_downs_a, dB_write_downs_a.getConnection()); dB_write_downs_a.openConnection();
                        MySqlDataAdapter mySqlDataAdapter_write_downs_a = new MySqlDataAdapter(mySqlCommand_write_downs_a);
                        DataSet dataSet_write_downs_a = new DataSet();
                        mySqlDataAdapter_write_downs_a.Fill(dataSet_write_downs_a);
                        grid_write_downs.DataSource = dataSet_write_downs_a.Tables[0].DefaultView;
                        dB_write_downs_a.closeConnection();
                    }

                    await Task.Delay(2000); 

                };
                while (true)
                {
                    await testFunc();
                }
            }
            
            GetDv();
            
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            string qwert = @"SELECT prava FROM otvetstvenai where ID=" + "'" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "'";
            DB dttt = new DB();

            MySqlCommand cmdd = new MySqlCommand(qwert, dttt.getConnection()); dttt.openConnection();
            DbDataReader rea = cmdd.ExecuteReader();
            rea.Read();

            satrudnikizm izm = new satrudnikizm(this);
            izm.Show();

            izm.textBox3.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            izm.textBox2.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            izm.textBox4.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            izm.textBox5.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            izm.comboBox1.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            if (rea[0].ToString() == "user")
                izm.user.Checked = true;
            if (rea[0].ToString() == "admin")
                izm.admin.Checked = true;
            dttt.closeConnection();
        }

        private void main_gred_DoubleClick(object sender, EventArgs e)
        {
            string qwert = @"SELECT * FROM bux where number=" + "'" + main_grid.CurrentRow.Cells[0].Value.ToString() + "'";
            DB dB_main_dc = new DB();

            MySqlCommand mySqlCommand_main_dc = new MySqlCommand(qwert, dB_main_dc.getConnection()); dB_main_dc.openConnection();
            DbDataReader dbDataReader_main_dc = mySqlCommand_main_dc.ExecuteReader();
            dbDataReader_main_dc.Read();
            Bux_editing_equipment bux_Editing_Equipment = new Bux_editing_equipment();
            bux_Editing_Equipment.Show();
            bux_Editing_Equipment.number.Text = dbDataReader_main_dc["number"].ToString();
            bux_Editing_Equipment.name.Text = dbDataReader_main_dc["name"].ToString();
            bux_Editing_Equipment.cost.Text = dbDataReader_main_dc["cost"].ToString();
            bux_Editing_Equipment.quantity.Text = dbDataReader_main_dc["quantity"].ToString();
            bux_Editing_Equipment.summ.Text = dbDataReader_main_dc["summ"].ToString();
            bux_Editing_Equipment.real_cost.Text = dbDataReader_main_dc["real_cost"].ToString();
            bux_Editing_Equipment.spi.Text = dbDataReader_main_dc["spi"].ToString();
            bux_Editing_Equipment.am_group.Text = dbDataReader_main_dc["am_group"].ToString();
            bux_Editing_Equipment.division.Text = dbDataReader_main_dc["division"].ToString();
            bux_Editing_Equipment.date.Text = dbDataReader_main_dc["date"].ToString();
            bux_Editing_Equipment.amortization.Text = dbDataReader_main_dc["amortization"].ToString();
            bux_Editing_Equipment.residual_cost.Text = dbDataReader_main_dc["residual_cost"].ToString();
            bux_Editing_Equipment.liquidated_cost.Text = dbDataReader_main_dc["liquidated_cost"].ToString();
            bux_Editing_Equipment.planned_production.Text = dbDataReader_main_dc["planned_production"].ToString();
            bux_Editing_Equipment.real_production.Text = dbDataReader_main_dc["real_production"].ToString();
            bux_Editing_Equipment.coefficient_bux.Text = dbDataReader_main_dc["coefficient"].ToString();
            if (dbDataReader_main_dc["method"].ToString() == "linear_bux")
                bux_Editing_Equipment.linear_bux.Checked = true;
            else if (dbDataReader_main_dc["method"].ToString() == "remains")
                bux_Editing_Equipment.remains.Checked = true;
            else if (dbDataReader_main_dc["method"].ToString() == "write_downs")
                bux_Editing_Equipment.write_downs.Checked = true;

        }

        private void main_gred_Click(object sender, EventArgs e)
        {
            string qwert = @"SELECT * FROM bux where number=" + "'" + main_grid.CurrentRow.Cells[0].Value.ToString() + "'";
            DB dB_main_click = new DB();

            MySqlCommand mySqlCommand_main_click = new MySqlCommand(qwert, dB_main_click.getConnection()); dB_main_click.openConnection();
            DbDataReader dbDataReader_main_click = mySqlCommand_main_click.ExecuteReader();
            dbDataReader_main_click.Read();

            number.Text = dbDataReader_main_click["number"].ToString();
            name.Text = dbDataReader_main_click["name"].ToString();
            cost.Text = dbDataReader_main_click["cost"].ToString();
            quantity.Text = dbDataReader_main_click["quantity"].ToString();
            summ.Text = dbDataReader_main_click["summ"].ToString();
            real_cost.Text = dbDataReader_main_click["real_cost"].ToString();
            spi.Text = dbDataReader_main_click["spi"].ToString();
            am_group.Text = dbDataReader_main_click["am_group"].ToString();
            division.Text = dbDataReader_main_click["division"].ToString();
            date.Text = dbDataReader_main_click["date"].ToString();
            amortization.Text = dbDataReader_main_click["amortization"].ToString();
            residual_cost.Text = dbDataReader_main_click["residual_cost"].ToString();   
            //label2.Text = "Процент износа = " + (100 * Convert.ToDouble(amortization.Text) / Convert.ToDouble(quantity.Text) * ((Convert.ToDouble(cost.Text) - Convert.ToDouble(dbDataReader_main_click["liquidated_cost"].ToString())))).ToString() + " %";
            dB_main_click.closeConnection();
        }

 

        private void button5_Click_1(object sender, EventArgs e)
        {
            //string poisk = @"Select Инвентарный_номер,Название,Группа_износа,Подразделение,Сумма_износа,Процент_износа,Ввод_в_эксплуотацию,Вывод_из_эксплуотации From oborudovanie Where Название Like '%" + poiskoborud.Text + "%'";
            //DB dt = new DB();                      поиск оборудования

            //MySqlCommand isk = new MySqlCommand(poisk, dt.getConnection());
            //MySqlDataAdapter net = new MySqlDataAdapter(isk);
            //DataSet ds = new DataSet();
            //net.Fill(ds);
            //main_grid.DataSource = ds.Tables[0].DefaultView;
            //dt.closeConnection();
        }

        private void udalitsatr_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить сотрудника?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string qwe = "delete from otdel where ID=" + dataGridView5.CurrentRow.Cells[0].Value.ToString() + "";
                DB ddt = new DB();

                MySqlCommand dcm = new MySqlCommand(qwe, ddt.getConnection());
                MySqlDataAdapter dnet = new MySqlDataAdapter(dcm);
                DataSet dds = new DataSet();
                dnet.Fill(dds); ddt.closeConnection();
            }
            else if (result == DialogResult.No)
            {

            }

            
        }

        private void ydolenie_Click(object sender, EventArgs e)
        {
            string qwe = "delete from oborudovanie where Инвентарный_номер=" + main_grid.CurrentRow.Cells[0].Value.ToString() + "";
            DB ddt = new DB();

            MySqlCommand dcm = new MySqlCommand(qwe, ddt.getConnection());
            MySqlDataAdapter dnet = new MySqlDataAdapter(dcm);
            DataSet dds = new DataSet();
            dnet.Fill(dds); ddt.closeConnection();

            string qwer = @"SELECT Инвентарный_номер,Название,Группа_износа,Подразделение,Сумма_износа,Процент_износа,Ввод_в_эксплуотацию,Вывод_из_эксплуотации FROM oborudovanie";
            DB dtt = new DB();

            MySqlCommand cmd = new MySqlCommand(qwer, dtt.getConnection());
            MySqlDataAdapter nett = new MySqlDataAdapter(cmd);
            DataSet dss = new DataSet();
            nett.Fill(dss);
            main_grid.DataSource = dss.Tables[0].DefaultView;
            dtt.closeConnection();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            string add = "INSERT INTO otdel (Название_отдела) VALUE ('" + textBox1.Text + "')";
            DB dt = new DB();

            MySqlCommand cm = new MySqlCommand(add, dt.getConnection());
            MySqlDataAdapter net = new MySqlDataAdapter(cm);
            DataSet ds = new DataSet();
            net.Fill(ds); dt.closeConnection();
        }

 

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView6_DoubleClick(object sender, EventArgs e)
        {
            new Nalog_editing_equipment().Show();
        }

        private void add_bux_Click_1(object sender, EventArgs e)
        {
            new add_equipment().Show();
        }

        private void add_nal_Click(object sender, EventArgs e)
        {
            new add_equipment().Show();
        }

        private void main_grid_nal_Click(object sender, EventArgs e)
        {
            string load = @"SELECT * FROM nal where number=" + "'" + main_grid_nal.CurrentRow.Cells[0].Value.ToString() + "'";
            DB dB_main_click = new DB();

            MySqlCommand mySqlCommand_main_click = new MySqlCommand(load, dB_main_click.getConnection()); dB_main_click.openConnection();
            DbDataReader dbDataReader_main_click = mySqlCommand_main_click.ExecuteReader();
            dbDataReader_main_click.Read();

            number_nal.Text = dbDataReader_main_click["number"].ToString();
            name_nal.Text = dbDataReader_main_click["name"].ToString();
            cost_nal.Text = dbDataReader_main_click["cost"].ToString();
            quantity_nal.Text = dbDataReader_main_click["quantity"].ToString();
            summ_nal.Text = dbDataReader_main_click["summ"].ToString();
            real_cost_nal.Text = dbDataReader_main_click["real_cost"].ToString();
            spi_nal.Text = dbDataReader_main_click["spi"].ToString();
            am_group_nal.Text = dbDataReader_main_click["am_group"].ToString();
            division_nal.Text = dbDataReader_main_click["division"].ToString();
            date_nal.Text = dbDataReader_main_click["date"].ToString();
            amortization_nal.Text = dbDataReader_main_click["amortization"].ToString();
            residual_cost_nal.Text = dbDataReader_main_click["residual_cost"].ToString();
            //label3.Text = "Процент износа = " + (100 * Convert.ToDouble(amortization_nal.Text) / Convert.ToDouble(quantity.Text) * Convert.ToDouble(Convert.ToDouble(cost_nal.Text) * (1 - (Convert.ToDouble(dbDataReader_main_click["prize_amor"].ToString()) * 0.01)))).ToString() + " %";
            dB_main_click.closeConnection();
        }

        private void main_grid_nal_DoubleClick(object sender, EventArgs e)
        {
            string qwert = @"SELECT * FROM nal where number=" + "'" + main_grid_nal.CurrentRow.Cells[0].Value.ToString() + "'";
            DB dB_main_dc_nal = new DB();

            MySqlCommand mySqlCommand_main_dc_nal = new MySqlCommand(qwert, dB_main_dc_nal.getConnection()); dB_main_dc_nal.openConnection();
            DbDataReader dbDataReader_main_dc_nal = mySqlCommand_main_dc_nal.ExecuteReader();
            dbDataReader_main_dc_nal.Read();
            Nalog_editing_equipment nalog_Editing_Equipment_nal = new Nalog_editing_equipment();
            nalog_Editing_Equipment_nal.Show();
            nalog_Editing_Equipment_nal.number.Text = dbDataReader_main_dc_nal["number"].ToString();
            nalog_Editing_Equipment_nal.name.Text = dbDataReader_main_dc_nal["name"].ToString();
            nalog_Editing_Equipment_nal.cost.Text = dbDataReader_main_dc_nal["cost"].ToString();
            nalog_Editing_Equipment_nal.quantity.Text = dbDataReader_main_dc_nal["quantity"].ToString();
            nalog_Editing_Equipment_nal.summ.Text = dbDataReader_main_dc_nal["summ"].ToString();
            nalog_Editing_Equipment_nal.real_cost.Text = dbDataReader_main_dc_nal["real_cost"].ToString();
            nalog_Editing_Equipment_nal.spi.Text = dbDataReader_main_dc_nal["spi"].ToString();
            nalog_Editing_Equipment_nal.am_group.Text = dbDataReader_main_dc_nal["am_group"].ToString();
            nalog_Editing_Equipment_nal.division.Text = dbDataReader_main_dc_nal["division"].ToString();
            nalog_Editing_Equipment_nal.date.Text = dbDataReader_main_dc_nal["date"].ToString();
            nalog_Editing_Equipment_nal.amortization.Text = dbDataReader_main_dc_nal["amortization"].ToString();
            nalog_Editing_Equipment_nal.residual_cost.Text = dbDataReader_main_dc_nal["residual_cost"].ToString();
            nalog_Editing_Equipment_nal.standart_amor.Text = dbDataReader_main_dc_nal["standart_amor"].ToString();
            nalog_Editing_Equipment_nal.coefficient_nal.Text = dbDataReader_main_dc_nal["coefficient"].ToString();
            nalog_Editing_Equipment_nal.prize_amor.Text = dbDataReader_main_dc_nal["prize_amor"].ToString();
            if (dbDataReader_main_dc_nal["method"].ToString() == "linear_nal")
                nalog_Editing_Equipment_nal.linear_nal.Checked = true;
            else if (dbDataReader_main_dc_nal["method"].ToString() == "non_linear_nal")
                nalog_Editing_Equipment_nal.non_linear_nal.Checked = true;

        }

        private void ecsport_Click(object sender, EventArgs e)
        {
            Excel_export excel_Export = new Excel_export();
            excel_Export.export(dataGridView4.CurrentRow.Cells[1].Value.ToString());
        }

        private void add_staff_Click(object sender, EventArgs e)
        {
            new satrudnikizm(this).Show();
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            var create = new word("os1.doc");

            var items = new Dictionary<string, string>
            {
                {"<date>", DateTime.Now.ToString() },
                {"<date_p>", date.Text },
                {"<date_s>", date.Text},
                {"<am_group>", am_group.Text },
                {"<number>", number.Text },
                {"<spi>", spi.Text },
                {"<price>",summ.Text },
                {"<name>",name.Text },
                {"<quantity>",quantity.Text },
            };

            create.Process(items);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var create = new word("os4.doc");

            var items = new Dictionary<string, string>
            {
                {"<dateNow>", DateTime.Now.ToString() },
                {"<date_p>", grid_write_downs.CurrentRow.Cells[8].Value.ToString() },
                {"<number>", grid_write_downs.CurrentRow.Cells[0].Value.ToString() },
                {"<spi>", grid_write_downs.CurrentRow.Cells[5].Value.ToString() },
                {"<price>",grid_write_downs.CurrentRow.Cells[4].Value.ToString() },
                {"<name>",grid_write_downs.CurrentRow.Cells[1].Value.ToString() },
                {"<quantity>",grid_write_downs.CurrentRow.Cells[3].Value.ToString() },
                {"<residual>",grid_write_downs.CurrentRow.Cells[6].Value.ToString() },
                {"<amor>", (Convert.ToDouble(grid_write_downs.CurrentRow.Cells[4].Value) - Convert.ToDouble(grid_write_downs.CurrentRow.Cells[6].Value)).ToString() },
            };

            create.Process(items);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Удалить сотрудника?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string delite_object = "delete from bux where number=" + "'" + main_grid_nal.CurrentRow.Cells[0].Value.ToString() + "'";
                DB dB_delite_object = new DB();
                MySqlCommand mySqlCommand_delite_object = new MySqlCommand(delite_object, dB_delite_object.getConnection()); dB_delite_object.openConnection();
                MySqlDataAdapter adapter_delite_object = new MySqlDataAdapter(mySqlCommand_delite_object);
                DataSet dataSet_delite_object = new DataSet();
                adapter_delite_object.Fill(dataSet_delite_object); dB_delite_object.closeConnection();
            }
            else if (result == DialogResult.No)
            {

            }


            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить сотрудника?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string delite_object = "delete from bux where number=" + "'" + main_grid.CurrentRow.Cells[0].Value.ToString() + "'";
                DB dB_delite_object = new DB();
                MySqlCommand mySqlCommand_delite_object = new MySqlCommand(delite_object, dB_delite_object.getConnection()); dB_delite_object.openConnection();
                MySqlDataAdapter adapter_delite_object = new MySqlDataAdapter(mySqlCommand_delite_object);
                DataSet dataSet_delite_object = new DataSet();
                adapter_delite_object.Fill(dataSet_delite_object); dB_delite_object.closeConnection();
            }
            else if (result == DialogResult.No)
            {

            }
        }
    }
}