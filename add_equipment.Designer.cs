namespace WindowsFormsApp1
{
    partial class add_equipment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.number = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.name = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.am_group = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.responsible = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cost = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.spi = new System.Windows.Forms.NumericUpDown();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.division = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.coefficient_bux = new System.Windows.Forms.NumericUpDown();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.linear_bux = new System.Windows.Forms.RadioButton();
            this.write_downs = new System.Windows.Forms.RadioButton();
            this.remains = new System.Windows.Forms.RadioButton();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.real_production = new System.Windows.Forms.NumericUpDown();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.planned_production = new System.Windows.Forms.NumericUpDown();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.liquidated_cost = new System.Windows.Forms.NumericUpDown();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.save = new System.Windows.Forms.Button();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.prize_amor = new System.Windows.Forms.NumericUpDown();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.coefficient_nal = new System.Windows.Forms.NumericUpDown();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.standart_amor = new System.Windows.Forms.NumericUpDown();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.linear_nal = new System.Windows.Forms.RadioButton();
            this.non_linear_nal = new System.Windows.Forms.RadioButton();
            this.dictionary = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cost)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spi)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            this.groupBox20.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coefficient_bux)).BeginInit();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.real_production)).BeginInit();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planned_production)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liquidated_cost)).BeginInit();
            this.groupBox14.SuspendLayout();
            this.groupBox18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prize_amor)).BeginInit();
            this.groupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coefficient_nal)).BeginInit();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standart_amor)).BeginInit();
            this.groupBox15.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.number);
            this.groupBox1.Location = new System.Drawing.Point(6, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инвентарный №";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(6, 19);
            this.number.Multiline = true;
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(95, 36);
            this.number.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.name);
            this.groupBox2.Location = new System.Drawing.Point(121, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 66);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Наименование";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(6, 20);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(284, 37);
            this.name.TabIndex = 0;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.am_group);
            this.groupBox3.Location = new System.Drawing.Point(6, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(167, 66);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Амортизационная группа";
            // 
            // am_group
            // 
            this.am_group.FormattingEnabled = true;
            this.am_group.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.am_group.Location = new System.Drawing.Point(6, 20);
            this.am_group.Name = "am_group";
            this.am_group.Size = new System.Drawing.Size(155, 21);
            this.am_group.TabIndex = 6;
            this.am_group.TextChanged += new System.EventHandler(this.am_group_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.responsible);
            this.groupBox4.Location = new System.Drawing.Point(361, 103);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(165, 66);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ответственный";
            // 
            // responsible
            // 
            this.responsible.FormattingEnabled = true;
            this.responsible.Location = new System.Drawing.Point(6, 20);
            this.responsible.Name = "responsible";
            this.responsible.Size = new System.Drawing.Size(155, 21);
            this.responsible.TabIndex = 7;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cost);
            this.groupBox5.Location = new System.Drawing.Point(518, 31);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 66);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Первоначальная стоимость";
            // 
            // cost
            // 
            this.cost.DecimalPlaces = 2;
            this.cost.Location = new System.Drawing.Point(6, 19);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(120, 20);
            this.cost.TabIndex = 24;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.spi);
            this.groupBox6.Location = new System.Drawing.Point(724, 31);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(194, 66);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Срок полезного использования";
            // 
            // spi
            // 
            this.spi.Location = new System.Drawing.Point(6, 21);
            this.spi.Name = "spi";
            this.spi.Size = new System.Drawing.Size(120, 20);
            this.spi.TabIndex = 23;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dictionary);
            this.groupBox7.Controls.Add(this.groupBox21);
            this.groupBox7.Controls.Add(this.groupBox20);
            this.groupBox7.Controls.Add(this.groupBox19);
            this.groupBox7.Controls.Add(this.groupBox2);
            this.groupBox7.Controls.Add(this.groupBox6);
            this.groupBox7.Controls.Add(this.groupBox1);
            this.groupBox7.Controls.Add(this.groupBox5);
            this.groupBox7.Controls.Add(this.groupBox3);
            this.groupBox7.Controls.Add(this.groupBox4);
            this.groupBox7.Location = new System.Drawing.Point(12, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(924, 175);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Общие данные";
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.quantity);
            this.groupBox21.Location = new System.Drawing.Point(427, 31);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(89, 66);
            this.groupBox21.TabIndex = 21;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Количество";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(6, 21);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(77, 20);
            this.quantity.TabIndex = 22;
            this.quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox20
            // 
            this.groupBox20.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox20.Controls.Add(this.date);
            this.groupBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox20.Location = new System.Drawing.Point(532, 103);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(165, 66);
            this.groupBox20.TabIndex = 20;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Дата ввода в эксплуотацию";
            // 
            // date
            // 
            this.date.Enabled = false;
            this.date.Location = new System.Drawing.Point(6, 20);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(145, 20);
            this.date.TabIndex = 0;
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.division);
            this.groupBox19.Location = new System.Drawing.Point(179, 103);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(176, 66);
            this.groupBox19.TabIndex = 6;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Подразделение";
            // 
            // division
            // 
            this.division.FormattingEnabled = true;
            this.division.Location = new System.Drawing.Point(6, 19);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(155, 21);
            this.division.TabIndex = 7;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.groupBox13);
            this.groupBox8.Controls.Add(this.groupBox12);
            this.groupBox8.Controls.Add(this.groupBox11);
            this.groupBox8.Controls.Add(this.groupBox10);
            this.groupBox8.Controls.Add(this.groupBox9);
            this.groupBox8.Location = new System.Drawing.Point(13, 193);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(923, 155);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Бухгалтерские данные";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.coefficient_bux);
            this.groupBox13.Location = new System.Drawing.Point(668, 77);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(147, 59);
            this.groupBox13.TabIndex = 8;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Коэффициент ускорения";
            // 
            // coefficient_bux
            // 
            this.coefficient_bux.DecimalPlaces = 2;
            this.coefficient_bux.Location = new System.Drawing.Point(6, 20);
            this.coefficient_bux.Name = "coefficient_bux";
            this.coefficient_bux.Size = new System.Drawing.Size(120, 20);
            this.coefficient_bux.TabIndex = 25;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.linear_bux);
            this.groupBox12.Controls.Add(this.write_downs);
            this.groupBox12.Controls.Add(this.remains);
            this.groupBox12.Location = new System.Drawing.Point(12, 19);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(695, 50);
            this.groupBox12.TabIndex = 7;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Способ расчёта";
            // 
            // linear_bux
            // 
            this.linear_bux.AutoSize = true;
            this.linear_bux.Location = new System.Drawing.Point(12, 19);
            this.linear_bux.Name = "linear_bux";
            this.linear_bux.Size = new System.Drawing.Size(116, 17);
            this.linear_bux.TabIndex = 4;
            this.linear_bux.TabStop = true;
            this.linear_bux.Text = "Линейный способ";
            this.linear_bux.UseVisualStyleBackColor = true;
            // 
            // write_downs
            // 
            this.write_downs.AutoSize = true;
            this.write_downs.Location = new System.Drawing.Point(324, 19);
            this.write_downs.Name = "write_downs";
            this.write_downs.Size = new System.Drawing.Size(360, 17);
            this.write_downs.TabIndex = 6;
            this.write_downs.TabStop = true;
            this.write_downs.Text = "Способ списания стоимости пропорционально объему продукции";
            this.write_downs.UseVisualStyleBackColor = true;
            // 
            // remains
            // 
            this.remains.AutoSize = true;
            this.remains.Location = new System.Drawing.Point(134, 19);
            this.remains.Name = "remains";
            this.remains.Size = new System.Drawing.Size(184, 17);
            this.remains.TabIndex = 5;
            this.remains.TabStop = true;
            this.remains.Text = "Способ уменьшаемого остатка";
            this.remains.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.real_production);
            this.groupBox11.Location = new System.Drawing.Point(426, 75);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(229, 60);
            this.groupBox11.TabIndex = 3;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Фактические показатели производства";
            // 
            // real_production
            // 
            this.real_production.Location = new System.Drawing.Point(51, 22);
            this.real_production.Name = "real_production";
            this.real_production.Size = new System.Drawing.Size(120, 20);
            this.real_production.TabIndex = 26;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.planned_production);
            this.groupBox10.Location = new System.Drawing.Point(203, 76);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(217, 60);
            this.groupBox10.TabIndex = 2;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = " Плановые показатели производства";
            // 
            // planned_production
            // 
            this.planned_production.Location = new System.Drawing.Point(46, 21);
            this.planned_production.Name = "planned_production";
            this.planned_production.Size = new System.Drawing.Size(120, 20);
            this.planned_production.TabIndex = 27;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.liquidated_cost);
            this.groupBox9.Location = new System.Drawing.Point(15, 75);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(182, 61);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Ликвидационная стоимость";
            // 
            // liquidated_cost
            // 
            this.liquidated_cost.DecimalPlaces = 2;
            this.liquidated_cost.Location = new System.Drawing.Point(18, 22);
            this.liquidated_cost.Name = "liquidated_cost";
            this.liquidated_cost.Size = new System.Drawing.Size(120, 20);
            this.liquidated_cost.TabIndex = 28;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.save);
            this.groupBox14.Controls.Add(this.groupBox18);
            this.groupBox14.Controls.Add(this.groupBox17);
            this.groupBox14.Controls.Add(this.groupBox16);
            this.groupBox14.Controls.Add(this.groupBox15);
            this.groupBox14.Location = new System.Drawing.Point(14, 354);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(922, 159);
            this.groupBox14.TabIndex = 8;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Налоговые данные";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(770, 95);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(130, 46);
            this.save.TabIndex = 12;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.prize_amor);
            this.groupBox18.Location = new System.Drawing.Point(414, 74);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(182, 67);
            this.groupBox18.TabIndex = 11;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Амортизационная премия";
            // 
            // prize_amor
            // 
            this.prize_amor.Location = new System.Drawing.Point(26, 22);
            this.prize_amor.Name = "prize_amor";
            this.prize_amor.Size = new System.Drawing.Size(120, 20);
            this.prize_amor.TabIndex = 31;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.coefficient_nal);
            this.groupBox17.Location = new System.Drawing.Point(158, 75);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(250, 66);
            this.groupBox17.TabIndex = 10;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Повышающий/Понижающий коэффициент";
            // 
            // coefficient_nal
            // 
            this.coefficient_nal.DecimalPlaces = 2;
            this.coefficient_nal.Location = new System.Drawing.Point(62, 21);
            this.coefficient_nal.Name = "coefficient_nal";
            this.coefficient_nal.Size = new System.Drawing.Size(109, 20);
            this.coefficient_nal.TabIndex = 30;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.standart_amor);
            this.groupBox16.Location = new System.Drawing.Point(9, 75);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(143, 66);
            this.groupBox16.TabIndex = 9;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Норма амортизации";
            // 
            // standart_amor
            // 
            this.standart_amor.DecimalPlaces = 2;
            this.standart_amor.Location = new System.Drawing.Point(11, 21);
            this.standart_amor.Name = "standart_amor";
            this.standart_amor.Size = new System.Drawing.Size(120, 20);
            this.standart_amor.TabIndex = 29;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.linear_nal);
            this.groupBox15.Controls.Add(this.non_linear_nal);
            this.groupBox15.Location = new System.Drawing.Point(11, 19);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(726, 50);
            this.groupBox15.TabIndex = 8;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Способ расчёта";
            // 
            // linear_nal
            // 
            this.linear_nal.AutoSize = true;
            this.linear_nal.Location = new System.Drawing.Point(12, 19);
            this.linear_nal.Name = "linear_nal";
            this.linear_nal.Size = new System.Drawing.Size(116, 17);
            this.linear_nal.TabIndex = 4;
            this.linear_nal.TabStop = true;
            this.linear_nal.Text = "Линейный способ";
            this.linear_nal.UseVisualStyleBackColor = true;
            // 
            // non_linear_nal
            // 
            this.non_linear_nal.AutoSize = true;
            this.non_linear_nal.Location = new System.Drawing.Point(134, 19);
            this.non_linear_nal.Name = "non_linear_nal";
            this.non_linear_nal.Size = new System.Drawing.Size(128, 17);
            this.non_linear_nal.TabIndex = 5;
            this.non_linear_nal.TabStop = true;
            this.non_linear_nal.Text = "Нелинейный способ";
            this.non_linear_nal.UseVisualStyleBackColor = true;
            // 
            // dictionary
            // 
            this.dictionary.FormattingEnabled = true;
            this.dictionary.Items.AddRange(new object[] {
            " \"комплекты инструмента для телекоммуникационного оборудования и линейно-кабельны" +
                "х работ\",",
            "  \"приспособления и оснастка для эксплуатационных работ в связи\",",
            " \"аппаратура / оборудование для исследований в скважинах\",",
            " \"оборудование для подготовительных работ при ремонте и обслуживании эксплуатацио" +
                "нных скважин\",",
            "\"инструмент строительно-монтажный ручной\"",
            " ,\"инструмент строительно-монтажный ручной\",",
            "\"насосы конденсатные\",",
            "\"насосы питательные\" ,",
            "\"насосы песковые\" ,",
            "\"насосы грунтовые\" ,",
            "\"насосы шламовые\" ,",
            "\"Компрессоры\",",
            " \"конвейеры ленточные\",",
            "\"конвейеры скребковые\",",
            "\"конвейеры передвижные\",",
            "\"оборудование для производства и монтажа вентиляционных и санитарно-технических з" +
                "аготовок и изделий\",",
            " \"нструмент и приспособления для производства и монтажа вентиляционных и санитарн" +
                "о-технических заготовок и изделий\",",
            "                \"средства крепления для производства и монтажа вентиляционных и с" +
                "анитарно-технических заготовок и изделий\",",
            "                \"механизмы для электромонтажных и пусконаладочных работ по оборуд" +
                "ованию промышленных предприятий\",",
            "                \"инструменты для электромонтажных и пусконаладочных работ по обор" +
                "удованию промышленных предприятий\",",
            "                \"приспособления для электромонтажных и пусконаладочных работ по о" +
                "борудованию промышленных предприятий\",",
            "                \"приборы и устройства для электромонтажных и пусконаладочных рабо" +
                "т по оборудованию промышленных предприятий\",",
            "                \"валки стальные, прокатные для сортопрокатных станов\",",
            "\"валки стальные, прокатные для полосовых станов\",",
            "                \"валки стальные, прокатные для листопрокатных  станов\",",
            "                \"инструмент медицинский\",",
            "\"инструмент для протезной промышленности\",",
            "\"Машины для выемки грунта: электрические \",",
            "                \"Машины для выемки грунта:пневматические\",",
            "                \"инструмент для металлообрабатывающих станков\",",
            "                \"инструмент для деревообрабатывающих станков\",",
            "\"дизели и дизель-генераторы с цилиндром диаметром свыше 160 мм\",",
            "                \"дизель и дизель-генераторы буровые\",",
            "                \"инструмент малой механизации лесохозяйственного применения, лесо" +
                "устроительного и таксационного назначения\",",
            "                \"инвентарь малой механизации лесохозяйственного применения, лесоу" +
                "строительного и таксационного назначения\",",
            "                \"средства малой механизации лесохозяйственного применения, лесоус" +
                "троительного и таксационного назначения\",",
            "                \"инструмент алмазный\",",
            "\"инструмент абразивный\",",
            "                \"молотки отбойные\",",
            "\"крепь проходческая механизированная\",",
            "\"двигатели забойные\",",
            "\"инструмент породоразрушающий (для нефтяных скважин) (турбобуры, буры, турбодолот" +
                "а, долота, отклонители, электробуры, расширители, калибраторы и прочие)\",",
            "                \"машины для зарядки и забойки взрывных скважин\",",
            "                \"оборудование для зарядки и забойки взрывных скважин\",",
            "                \"замки концы к бурильным трубам\",",
            "\"соединительные концы к бурильным трубам\",",
            "                \"элементы компоновки низа бурильной колонны\",",
            "\"замки буровые для электробура\",",
            "                \"замки буровые специальные\",",
            "                \"инструмент ловильный для ликвидации аварий при бурении\",",
            "                \"инструмент и приспособления для зарезки вторых стволов\",",
            "                \"инструмент буровой (кроме породоразрушающего)\",",
            "                \"инструмент для свинчивания - развинчивания и удержания на весу н" +
                "асосно-компрессорных труб и штанг при ремонте эксплуатационных скважин\",",
            "                \"инструмент ловильный для эксплуатационных скважин\",",
            "                \"инструмент для бурения геолого-разведочных скважин\",",
            "                \"инструмент для нефтепромыслового и геолого-разведочного оборудов" +
                "ания\""});
            this.dictionary.Location = new System.Drawing.Point(703, 122);
            this.dictionary.Name = "dictionary";
            this.dictionary.Size = new System.Drawing.Size(121, 21);
            this.dictionary.TabIndex = 22;
            this.dictionary.TextChanged += new System.EventHandler(this.dictionary_TextChanged);
            // 
            // add_equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 525);
            this.Controls.Add(this.groupBox14);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Name = "add_equipment";
            this.Text = "add_equipment";
            this.Load += new System.EventHandler(this.add_equipment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cost)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spi)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            this.groupBox20.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coefficient_bux)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.real_production)).EndInit();
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.planned_production)).EndInit();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.liquidated_cost)).EndInit();
            this.groupBox14.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prize_amor)).EndInit();
            this.groupBox17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coefficient_nal)).EndInit();
            this.groupBox16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.standart_amor)).EndInit();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox am_group;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox responsible;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.ComboBox division;
        private System.Windows.Forms.GroupBox groupBox20;
        internal System.Windows.Forms.RadioButton write_downs;
        internal System.Windows.Forms.RadioButton remains;
        internal System.Windows.Forms.RadioButton linear_nal;
        internal System.Windows.Forms.RadioButton non_linear_nal;
        internal System.Windows.Forms.RadioButton linear_bux;
        internal System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.NumericUpDown standart_amor;
        private System.Windows.Forms.NumericUpDown liquidated_cost;
        private System.Windows.Forms.NumericUpDown planned_production;
        private System.Windows.Forms.NumericUpDown real_production;
        private System.Windows.Forms.NumericUpDown coefficient_bux;
        private System.Windows.Forms.NumericUpDown cost;
        private System.Windows.Forms.NumericUpDown spi;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.NumericUpDown coefficient_nal;
        private System.Windows.Forms.NumericUpDown prize_amor;
        private System.Windows.Forms.ComboBox dictionary;
    }
}