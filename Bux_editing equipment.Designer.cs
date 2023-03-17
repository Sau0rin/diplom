namespace WindowsFormsApp1
{
    partial class Bux_editing_equipment
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
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.coefficient_bux = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.linear_bux = new System.Windows.Forms.RadioButton();
            this.write_downs = new System.Windows.Forms.RadioButton();
            this.remains = new System.Windows.Forms.RadioButton();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.liquidated_cost = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox33 = new System.Windows.Forms.GroupBox();
            this.summ = new System.Windows.Forms.TextBox();
            this.groupBox30 = new System.Windows.Forms.GroupBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.residual_cost = new System.Windows.Forms.TextBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.amortization = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.real_cost = new System.Windows.Forms.TextBox();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.division = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.name = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.spi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.number = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cost = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.am_group = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.responsible = new System.Windows.Forms.ComboBox();
            this.update_bux = new System.Windows.Forms.Button();
            this.planned_production = new System.Windows.Forms.NumericUpDown();
            this.real_production = new System.Windows.Forms.NumericUpDown();
            this.groupBox8.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox33.SuspendLayout();
            this.groupBox30.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planned_production)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.real_production)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.groupBox13);
            this.groupBox8.Controls.Add(this.groupBox12);
            this.groupBox8.Controls.Add(this.groupBox11);
            this.groupBox8.Controls.Add(this.groupBox10);
            this.groupBox8.Controls.Add(this.groupBox9);
            this.groupBox8.Location = new System.Drawing.Point(12, 228);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(825, 155);
            this.groupBox8.TabIndex = 9;
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
            this.coefficient_bux.Enabled = false;
            this.coefficient_bux.Location = new System.Drawing.Point(7, 20);
            this.coefficient_bux.Multiline = true;
            this.coefficient_bux.Name = "coefficient_bux";
            this.coefficient_bux.ReadOnly = true;
            this.coefficient_bux.Size = new System.Drawing.Size(129, 28);
            this.coefficient_bux.TabIndex = 0;
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
            this.linear_bux.Enabled = false;
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
            this.write_downs.Enabled = false;
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
            this.remains.Enabled = false;
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
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.liquidated_cost);
            this.groupBox9.Location = new System.Drawing.Point(15, 75);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(182, 61);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Ликведационная стоимость";
            // 
            // liquidated_cost
            // 
            this.liquidated_cost.Enabled = false;
            this.liquidated_cost.Location = new System.Drawing.Point(6, 19);
            this.liquidated_cost.Multiline = true;
            this.liquidated_cost.Name = "liquidated_cost";
            this.liquidated_cost.ReadOnly = true;
            this.liquidated_cost.Size = new System.Drawing.Size(165, 30);
            this.liquidated_cost.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox33);
            this.groupBox7.Controls.Add(this.groupBox30);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.groupBox20);
            this.groupBox7.Controls.Add(this.groupBox16);
            this.groupBox7.Controls.Add(this.groupBox15);
            this.groupBox7.Controls.Add(this.groupBox14);
            this.groupBox7.Controls.Add(this.groupBox19);
            this.groupBox7.Controls.Add(this.groupBox2);
            this.groupBox7.Controls.Add(this.groupBox6);
            this.groupBox7.Controls.Add(this.groupBox1);
            this.groupBox7.Controls.Add(this.groupBox5);
            this.groupBox7.Controls.Add(this.groupBox3);
            this.groupBox7.Controls.Add(this.groupBox4);
            this.groupBox7.Location = new System.Drawing.Point(12, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1325, 210);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Общие данные";
            // 
            // groupBox33
            // 
            this.groupBox33.Controls.Add(this.summ);
            this.groupBox33.Location = new System.Drawing.Point(823, 33);
            this.groupBox33.Name = "groupBox33";
            this.groupBox33.Size = new System.Drawing.Size(89, 66);
            this.groupBox33.TabIndex = 32;
            this.groupBox33.TabStop = false;
            this.groupBox33.Text = "Сумма";
            // 
            // summ
            // 
            this.summ.Enabled = false;
            this.summ.Location = new System.Drawing.Point(5, 19);
            this.summ.Multiline = true;
            this.summ.Name = "summ";
            this.summ.Size = new System.Drawing.Size(80, 35);
            this.summ.TabIndex = 0;
            // 
            // groupBox30
            // 
            this.groupBox30.Controls.Add(this.quantity);
            this.groupBox30.Location = new System.Drawing.Point(708, 33);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Size = new System.Drawing.Size(109, 66);
            this.groupBox30.TabIndex = 31;
            this.groupBox30.TabStop = false;
            this.groupBox30.Text = "Количество";
            // 
            // quantity
            // 
            this.quantity.Enabled = false;
            this.quantity.Location = new System.Drawing.Point(5, 19);
            this.quantity.Multiline = true;
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(95, 35);
            this.quantity.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 28;
            // 
            // groupBox20
            // 
            this.groupBox20.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox20.Controls.Add(this.date);
            this.groupBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox20.Location = new System.Drawing.Point(532, 103);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(165, 66);
            this.groupBox20.TabIndex = 26;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Дата ввода в эксплуотацию";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(7, 21);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(152, 20);
            this.date.TabIndex = 0;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.residual_cost);
            this.groupBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox16.Location = new System.Drawing.Point(878, 103);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(228, 66);
            this.groupBox16.TabIndex = 25;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Остаточная стоимсоть";
            // 
            // residual_cost
            // 
            this.residual_cost.Enabled = false;
            this.residual_cost.Location = new System.Drawing.Point(6, 19);
            this.residual_cost.Multiline = true;
            this.residual_cost.Name = "residual_cost";
            this.residual_cost.ReadOnly = true;
            this.residual_cost.Size = new System.Drawing.Size(216, 36);
            this.residual_cost.TabIndex = 0;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.amortization);
            this.groupBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox15.Location = new System.Drawing.Point(703, 105);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(169, 64);
            this.groupBox15.TabIndex = 24;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Сумма амортизации";
            // 
            // amortization
            // 
            this.amortization.Enabled = false;
            this.amortization.Location = new System.Drawing.Point(6, 19);
            this.amortization.Multiline = true;
            this.amortization.Name = "amortization";
            this.amortization.ReadOnly = true;
            this.amortization.Size = new System.Drawing.Size(157, 36);
            this.amortization.TabIndex = 0;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.real_cost);
            this.groupBox14.Location = new System.Drawing.Point(918, 33);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(198, 66);
            this.groupBox14.TabIndex = 7;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Восстановительная стоимость";
            // 
            // real_cost
            // 
            this.real_cost.Location = new System.Drawing.Point(6, 17);
            this.real_cost.Multiline = true;
            this.real_cost.Name = "real_cost";
            this.real_cost.Size = new System.Drawing.Size(187, 38);
            this.real_cost.TabIndex = 1;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.name);
            this.groupBox2.Location = new System.Drawing.Point(194, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 66);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Наименование";
            // 
            // name
            // 
            this.name.Enabled = false;
            this.name.Location = new System.Drawing.Point(6, 20);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(284, 37);
            this.name.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.spi);
            this.groupBox6.Location = new System.Drawing.Point(1122, 33);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(194, 66);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Срок полезного использования";
            // 
            // spi
            // 
            this.spi.Enabled = false;
            this.spi.Location = new System.Drawing.Point(7, 20);
            this.spi.Multiline = true;
            this.spi.Name = "spi";
            this.spi.ReadOnly = true;
            this.spi.Size = new System.Drawing.Size(181, 37);
            this.spi.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.number);
            this.groupBox1.Location = new System.Drawing.Point(6, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инвентарный №";
            // 
            // number
            // 
            this.number.Enabled = false;
            this.number.Location = new System.Drawing.Point(6, 19);
            this.number.Multiline = true;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Size = new System.Drawing.Size(165, 36);
            this.number.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cost);
            this.groupBox5.Location = new System.Drawing.Point(502, 31);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 66);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Первоначальная стоимость";
            // 
            // cost
            // 
            this.cost.Enabled = false;
            this.cost.Location = new System.Drawing.Point(7, 19);
            this.cost.Multiline = true;
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            this.cost.Size = new System.Drawing.Size(187, 38);
            this.cost.TabIndex = 0;
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
            // update_bux
            // 
            this.update_bux.Location = new System.Drawing.Point(1022, 322);
            this.update_bux.Name = "update_bux";
            this.update_bux.Size = new System.Drawing.Size(119, 53);
            this.update_bux.TabIndex = 10;
            this.update_bux.Text = "Обновить";
            this.update_bux.UseVisualStyleBackColor = true;
            this.update_bux.Click += new System.EventHandler(this.update_bux_Click);
            // 
            // planned_production
            // 
            this.planned_production.Location = new System.Drawing.Point(32, 22);
            this.planned_production.Name = "planned_production";
            this.planned_production.Size = new System.Drawing.Size(120, 20);
            this.planned_production.TabIndex = 11;
            // 
            // real_production
            // 
            this.real_production.Location = new System.Drawing.Point(30, 23);
            this.real_production.Name = "real_production";
            this.real_production.Size = new System.Drawing.Size(120, 20);
            this.real_production.TabIndex = 12;
            // 
            // Bux_editing_equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 390);
            this.Controls.Add(this.update_bux);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Name = "Bux_editing_equipment";
            this.Text = "Bux_editing_equipment";
            this.Load += new System.EventHandler(this.Bux_editing_equipment_Load);
            this.groupBox8.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox33.ResumeLayout(false);
            this.groupBox33.PerformLayout();
            this.groupBox30.ResumeLayout(false);
            this.groupBox30.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.planned_production)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.real_production)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox16;
        internal System.Windows.Forms.TextBox residual_cost;
        private System.Windows.Forms.GroupBox groupBox15;
        internal System.Windows.Forms.TextBox amortization;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button update_bux;
        internal System.Windows.Forms.TextBox coefficient_bux;
        internal System.Windows.Forms.TextBox liquidated_cost;
        internal System.Windows.Forms.TextBox real_cost;
        internal System.Windows.Forms.ComboBox division;
        internal System.Windows.Forms.TextBox name;
        internal System.Windows.Forms.TextBox spi;
        internal System.Windows.Forms.TextBox number;
        internal System.Windows.Forms.TextBox cost;
        internal System.Windows.Forms.ComboBox am_group;
        internal System.Windows.Forms.ComboBox responsible;
        internal System.Windows.Forms.RadioButton linear_bux;
        internal System.Windows.Forms.RadioButton write_downs;
        internal System.Windows.Forms.RadioButton remains;
        private System.Windows.Forms.GroupBox groupBox33;
        private System.Windows.Forms.GroupBox groupBox30;
        internal System.Windows.Forms.TextBox summ;
        internal System.Windows.Forms.TextBox quantity;
        internal System.Windows.Forms.DateTimePicker date;
        internal System.Windows.Forms.NumericUpDown real_production;
        internal System.Windows.Forms.NumericUpDown planned_production;
    }
}