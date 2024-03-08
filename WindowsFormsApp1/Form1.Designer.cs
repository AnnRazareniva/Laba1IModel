namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edHigh = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.VVend = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.Label();
            this.Dist1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.edStep = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.edSize = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.edWeight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.edAngle = new System.Windows.Forms.NumericUpDown();
            this.edSpeed = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.edHigh);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.VVend);
            this.panel1.Controls.Add(this.Height);
            this.panel1.Controls.Add(this.Dist1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.edStep);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.edSize);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.edWeight);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.edAngle);
            this.panel1.Controls.Add(this.edSpeed);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 297);
            this.panel1.TabIndex = 0;
            // 
            // edHigh
            // 
            this.edHigh.DecimalPlaces = 4;
            this.edHigh.Location = new System.Drawing.Point(448, 117);
            this.edHigh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edHigh.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.edHigh.Name = "edHigh";
            this.edHigh.Size = new System.Drawing.Size(160, 22);
            this.edHigh.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(367, 119);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "Высота";
            // 
            // VVend
            // 
            this.VVend.AutoSize = true;
            this.VVend.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.VVend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VVend.Location = new System.Drawing.Point(536, 262);
            this.VVend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VVend.Name = "VVend";
            this.VVend.Size = new System.Drawing.Size(146, 18);
            this.VVend.TabIndex = 22;
            this.VVend.Text = "Данные отсутствуют";
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Height.Location = new System.Drawing.Point(139, 265);
            this.Height.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(146, 18);
            this.Height.TabIndex = 21;
            this.Height.Text = "Данные отсутствуют";
            // 
            // Dist1
            // 
            this.Dist1.AutoSize = true;
            this.Dist1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Dist1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Dist1.Location = new System.Drawing.Point(536, 220);
            this.Dist1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dist1.Name = "Dist1";
            this.Dist1.Size = new System.Drawing.Size(146, 18);
            this.Dist1.TabIndex = 20;
            this.Dist1.Text = "Данные отсутствуют";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(335, 223);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Расстояние";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 265);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Макс. Высота";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(335, 265);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Скорость в конечной точке";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ввод данных";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 182);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Результаты";
            // 
            // edStep
            // 
            this.edStep.DecimalPlaces = 4;
            this.edStep.Location = new System.Drawing.Point(448, 52);
            this.edStep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edStep.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            589824});
            this.edStep.Name = "edStep";
            this.edStep.Size = new System.Drawing.Size(160, 22);
            this.edStep.TabIndex = 12;
            this.edStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Шаг";
            // 
            // edSize
            // 
            this.edSize.DecimalPlaces = 4;
            this.edSize.Location = new System.Drawing.Point(763, 117);
            this.edSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edSize.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            589824});
            this.edSize.Name = "edSize";
            this.edSize.Size = new System.Drawing.Size(160, 22);
            this.edSize.TabIndex = 10;
            this.edSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(681, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Размер";
            // 
            // edWeight
            // 
            this.edWeight.DecimalPlaces = 4;
            this.edWeight.Location = new System.Drawing.Point(763, 57);
            this.edWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edWeight.Name = "edWeight";
            this.edWeight.Size = new System.Drawing.Size(160, 22);
            this.edWeight.TabIndex = 8;
            this.edWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(681, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Вес";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(987, 100);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 87);
            this.button1.TabIndex = 6;
            this.button1.Text = "ПУСК!!!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // edAngle
            // 
            this.edAngle.Location = new System.Drawing.Point(132, 52);
            this.edAngle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edAngle.Name = "edAngle";
            this.edAngle.Size = new System.Drawing.Size(160, 22);
            this.edAngle.TabIndex = 4;
            this.edAngle.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // edSpeed
            // 
            this.edSpeed.Location = new System.Drawing.Point(132, 117);
            this.edSpeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edSpeed.Name = "edSpeed";
            this.edSpeed.Size = new System.Drawing.Size(160, 22);
            this.edSpeed.TabIndex = 3;
            this.edSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Скорость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Угол";
            // 
            // chart1
            // 
            chartArea1.AxisX.Maximum = 25D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 6D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 345);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1151, 559);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 918);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown edAngle;
        private System.Windows.Forms.NumericUpDown edSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown edSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown edWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown edStep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label VVend;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.Label Dist1;
        private System.Windows.Forms.NumericUpDown edHigh;
        private System.Windows.Forms.Label label12;
    }
}

