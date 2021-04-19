namespace simple_object
{
    partial class main_form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.waterLevel1 = new System.Windows.Forms.Label();
            this.inputBoiler = new System.Windows.Forms.Label();
            this.chPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tmModeling = new System.Windows.Forms.Timer(this.components);
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.scale10 = new System.Windows.Forms.Button();
            this.scale1 = new System.Windows.Forms.Button();
            this.scaleUp = new System.Windows.Forms.Button();
            this.scaleDown = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.value_xin1 = new System.Windows.Forms.TextBox();
            this.label_1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.value_xin2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.value_xout1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.value_x12 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.waterLeve2 = new System.Windows.Forms.Label();
            this.value_out2 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chPlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // waterLevel1
            // 
            this.waterLevel1.AutoSize = true;
            this.waterLevel1.Location = new System.Drawing.Point(536, 180);
            this.waterLevel1.Name = "waterLevel1";
            this.waterLevel1.Size = new System.Drawing.Size(0, 17);
            this.waterLevel1.TabIndex = 1;
            // 
            // inputBoiler
            // 
            this.inputBoiler.AutoSize = true;
            this.inputBoiler.Location = new System.Drawing.Point(154, 186);
            this.inputBoiler.Name = "inputBoiler";
            this.inputBoiler.Size = new System.Drawing.Size(0, 17);
            this.inputBoiler.TabIndex = 2;
            // 
            // chPlot
            // 
            chartArea1.Name = "ChartArea2";
            chartArea2.Name = "ChartArea1";
            this.chPlot.ChartAreas.Add(chartArea1);
            this.chPlot.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            this.chPlot.Legends.Add(legend1);
            this.chPlot.Location = new System.Drawing.Point(139, 305);
            this.chPlot.Name = "chPlot";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "z1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "z2";
            this.chPlot.Series.Add(series1);
            this.chPlot.Series.Add(series2);
            this.chPlot.Size = new System.Drawing.Size(871, 351);
            this.chPlot.TabIndex = 3;
            this.chPlot.Text = "chart1";
            // 
            // tmModeling
            // 
            this.tmModeling.Interval = 1000;
            this.tmModeling.Tick += new System.EventHandler(this.tmModeling_Tick);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(1, 12);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 65);
            this.Start.TabIndex = 4;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(1, 75);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 42);
            this.Stop.TabIndex = 5;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // scale10
            // 
            this.scale10.Location = new System.Drawing.Point(1, 151);
            this.scale10.Name = "scale10";
            this.scale10.Size = new System.Drawing.Size(75, 23);
            this.scale10.TabIndex = 6;
            this.scale10.Text = "x10";
            this.scale10.UseVisualStyleBackColor = true;
            this.scale10.Click += new System.EventHandler(this.scale10_Click);
            // 
            // scale1
            // 
            this.scale1.Location = new System.Drawing.Point(1, 180);
            this.scale1.Name = "scale1";
            this.scale1.Size = new System.Drawing.Size(75, 23);
            this.scale1.TabIndex = 7;
            this.scale1.Text = "x1";
            this.scale1.UseVisualStyleBackColor = true;
            this.scale1.Click += new System.EventHandler(this.scale1_Click);
            // 
            // scaleUp
            // 
            this.scaleUp.Location = new System.Drawing.Point(163, 183);
            this.scaleUp.Name = "scaleUp";
            this.scaleUp.Size = new System.Drawing.Size(75, 23);
            this.scaleUp.TabIndex = 8;
            this.scaleUp.Text = ">";
            this.scaleUp.UseVisualStyleBackColor = true;
            this.scaleUp.Click += new System.EventHandler(this.scaleUp_Click);
            // 
            // scaleDown
            // 
            this.scaleDown.Location = new System.Drawing.Point(85, 183);
            this.scaleDown.Name = "scaleDown";
            this.scaleDown.Size = new System.Drawing.Size(75, 23);
            this.scaleDown.TabIndex = 9;
            this.scaleDown.Text = "<";
            this.scaleDown.UseVisualStyleBackColor = true;
            this.scaleDown.Click += new System.EventHandler(this.scaleDown_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::simple_object.Properties.Resources.image_2021_03_21_21_03_23;
            this.pictureBox1.Location = new System.Drawing.Point(346, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(622, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // value_xin1
            // 
            this.value_xin1.Location = new System.Drawing.Point(240, 50);
            this.value_xin1.Name = "value_xin1";
            this.value_xin1.Size = new System.Drawing.Size(100, 22);
            this.value_xin1.TabIndex = 11;
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Location = new System.Drawing.Point(265, 30);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(40, 17);
            this.label_1.TabIndex = 12;
            this.label_1.Text = "X in1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "X in 2";
            // 
            // value_xin2
            // 
            this.value_xin2.Location = new System.Drawing.Point(240, 95);
            this.value_xin2.Name = "value_xin2";
            this.value_xin2.Size = new System.Drawing.Size(100, 22);
            this.value_xin2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "X out1";
            // 
            // value_xout1
            // 
            this.value_xout1.Location = new System.Drawing.Point(240, 184);
            this.value_xout1.Name = "value_xout1";
            this.value_xout1.Size = new System.Drawing.Size(100, 22);
            this.value_xout1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "X 1-2";
            // 
            // value_x12
            // 
            this.value_x12.Location = new System.Drawing.Point(240, 139);
            this.value_x12.Name = "value_x12";
            this.value_x12.Size = new System.Drawing.Size(100, 22);
            this.value_x12.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(163, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 19;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(85, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(163, 94);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = ">";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 22;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(82, 138);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 27;
            this.button6.Text = "<";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(163, 138);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 26;
            this.button7.Text = ">";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 25;
            // 
            // waterLeve2
            // 
            this.waterLeve2.AutoSize = true;
            this.waterLeve2.Location = new System.Drawing.Point(777, 180);
            this.waterLeve2.Name = "waterLeve2";
            this.waterLeve2.Size = new System.Drawing.Size(0, 17);
            this.waterLeve2.TabIndex = 28;
            // 
            // value_out2
            // 
            this.value_out2.Location = new System.Drawing.Point(240, 233);
            this.value_out2.Name = "value_out2";
            this.value_out2.Size = new System.Drawing.Size(100, 22);
            this.value_out2.TabIndex = 32;
            this.value_out2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(85, 232);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 31;
            this.button8.Text = "<";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(163, 232);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 30;
            this.button9.Text = ">";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(265, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "out2";
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 668);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.value_out2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.waterLeve2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.value_xout1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.value_x12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.value_xin2);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.value_xin1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.scaleDown);
            this.Controls.Add(this.scaleUp);
            this.Controls.Add(this.scale1);
            this.Controls.Add(this.scale10);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.chPlot);
            this.Controls.Add(this.inputBoiler);
            this.Controls.Add(this.waterLevel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "main_form";
            this.Text = "TWO TANKS";
            ((System.ComponentModel.ISupportInitialize)(this.chPlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label waterLevel1;
        private System.Windows.Forms.Label inputBoiler;
        private System.Windows.Forms.DataVisualization.Charting.Chart chPlot;
        private System.Windows.Forms.Timer tmModeling;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button scale10;
        private System.Windows.Forms.Button scale1;
        private System.Windows.Forms.Button scaleUp;
        private System.Windows.Forms.Button scaleDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox value_xin1;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox value_xin2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox value_xout1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox value_x12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label waterLeve2;
        private System.Windows.Forms.TextBox value_out2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

