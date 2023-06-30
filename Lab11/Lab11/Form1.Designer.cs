namespace Lab11
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.MeanNum = new System.Windows.Forms.NumericUpDown();
            this.VarianceNum = new System.Windows.Forms.NumericUpDown();
            this.SizeNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Val1Ed1 = new System.Windows.Forms.NumericUpDown();
            this.Val1Ed2 = new System.Windows.Forms.NumericUpDown();
            this.Val1Ed3 = new System.Windows.Forms.NumericUpDown();
            this.Val1Ed4 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Val1Ed5 = new System.Windows.Forms.NumericUpDown();
            this.numEd = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.EmpVer1 = new System.Windows.Forms.TextBox();
            this.vibSredLbl = new System.Windows.Forms.TextBox();
            this.DLbl = new System.Windows.Forms.TextBox();
            this.chiLbl = new System.Windows.Forms.TextBox();
            this.EmpVer4 = new System.Windows.Forms.TextBox();
            this.EmpVer2 = new System.Windows.Forms.TextBox();
            this.EmpVer5 = new System.Windows.Forms.TextBox();
            this.EmpVer3 = new System.Windows.Forms.TextBox();
            this.GenBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MeanNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VarianceNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val1Ed1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val1Ed2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val1Ed3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val1Ed4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val1Ed5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mean";
            // 
            // MeanNum
            // 
            this.MeanNum.Location = new System.Drawing.Point(101, 12);
            this.MeanNum.Name = "MeanNum";
            this.MeanNum.Size = new System.Drawing.Size(120, 22);
            this.MeanNum.TabIndex = 1;
            // 
            // VarianceNum
            // 
            this.VarianceNum.Location = new System.Drawing.Point(101, 40);
            this.VarianceNum.Name = "VarianceNum";
            this.VarianceNum.Size = new System.Drawing.Size(120, 22);
            this.VarianceNum.TabIndex = 2;
            // 
            // SizeNum
            // 
            this.SizeNum.Location = new System.Drawing.Point(101, 68);
            this.SizeNum.Name = "SizeNum";
            this.SizeNum.Size = new System.Drawing.Size(120, 22);
            this.SizeNum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Variance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sample Size";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(146, 96);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 6;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(227, 12);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(561, 275);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // Val1Ed1
            // 
            this.Val1Ed1.Location = new System.Drawing.Point(101, 125);
            this.Val1Ed1.Name = "Val1Ed1";
            this.Val1Ed1.Size = new System.Drawing.Size(120, 22);
            this.Val1Ed1.TabIndex = 8;
            // 
            // Val1Ed2
            // 
            this.Val1Ed2.Location = new System.Drawing.Point(101, 153);
            this.Val1Ed2.Name = "Val1Ed2";
            this.Val1Ed2.Size = new System.Drawing.Size(120, 22);
            this.Val1Ed2.TabIndex = 9;
            // 
            // Val1Ed3
            // 
            this.Val1Ed3.Location = new System.Drawing.Point(101, 181);
            this.Val1Ed3.Name = "Val1Ed3";
            this.Val1Ed3.Size = new System.Drawing.Size(120, 22);
            this.Val1Ed3.TabIndex = 10;
            // 
            // Val1Ed4
            // 
            this.Val1Ed4.Location = new System.Drawing.Point(101, 209);
            this.Val1Ed4.Name = "Val1Ed4";
            this.Val1Ed4.Size = new System.Drawing.Size(120, 22);
            this.Val1Ed4.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Value 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Value 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Value 3:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Value 4:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Value 5:";
            // 
            // Val1Ed5
            // 
            this.Val1Ed5.Location = new System.Drawing.Point(101, 237);
            this.Val1Ed5.Name = "Val1Ed5";
            this.Val1Ed5.ReadOnly = true;
            this.Val1Ed5.Size = new System.Drawing.Size(120, 22);
            this.Val1Ed5.TabIndex = 18;
            this.Val1Ed5.ValueChanged += new System.EventHandler(this.Val1Ed5_ValueChanged);
            // 
            // numEd
            // 
            this.numEd.Location = new System.Drawing.Point(101, 265);
            this.numEd.Name = "numEd";
            this.numEd.Size = new System.Drawing.Size(120, 22);
            this.numEd.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Number:";
            // 
            // EmpVer1
            // 
            this.EmpVer1.Location = new System.Drawing.Point(12, 293);
            this.EmpVer1.Name = "EmpVer1";
            this.EmpVer1.Size = new System.Drawing.Size(209, 22);
            this.EmpVer1.TabIndex = 21;
            // 
            // vibSredLbl
            // 
            this.vibSredLbl.Location = new System.Drawing.Point(12, 360);
            this.vibSredLbl.Name = "vibSredLbl";
            this.vibSredLbl.Size = new System.Drawing.Size(776, 22);
            this.vibSredLbl.TabIndex = 22;
            // 
            // DLbl
            // 
            this.DLbl.Location = new System.Drawing.Point(12, 388);
            this.DLbl.Name = "DLbl";
            this.DLbl.Size = new System.Drawing.Size(776, 22);
            this.DLbl.TabIndex = 23;
            // 
            // chiLbl
            // 
            this.chiLbl.Location = new System.Drawing.Point(12, 416);
            this.chiLbl.Name = "chiLbl";
            this.chiLbl.Size = new System.Drawing.Size(776, 22);
            this.chiLbl.TabIndex = 24;
            // 
            // EmpVer4
            // 
            this.EmpVer4.Location = new System.Drawing.Point(12, 321);
            this.EmpVer4.Name = "EmpVer4";
            this.EmpVer4.Size = new System.Drawing.Size(209, 22);
            this.EmpVer4.TabIndex = 25;
            // 
            // EmpVer2
            // 
            this.EmpVer2.Location = new System.Drawing.Point(227, 293);
            this.EmpVer2.Name = "EmpVer2";
            this.EmpVer2.Size = new System.Drawing.Size(209, 22);
            this.EmpVer2.TabIndex = 26;
            // 
            // EmpVer5
            // 
            this.EmpVer5.Location = new System.Drawing.Point(227, 321);
            this.EmpVer5.Name = "EmpVer5";
            this.EmpVer5.Size = new System.Drawing.Size(209, 22);
            this.EmpVer5.TabIndex = 27;
            // 
            // EmpVer3
            // 
            this.EmpVer3.Location = new System.Drawing.Point(439, 293);
            this.EmpVer3.Name = "EmpVer3";
            this.EmpVer3.Size = new System.Drawing.Size(209, 22);
            this.EmpVer3.TabIndex = 28;
            // 
            // GenBtn
            // 
            this.GenBtn.Location = new System.Drawing.Point(12, 96);
            this.GenBtn.Name = "GenBtn";
            this.GenBtn.Size = new System.Drawing.Size(75, 23);
            this.GenBtn.TabIndex = 29;
            this.GenBtn.Text = "Generate";
            this.GenBtn.UseVisualStyleBackColor = true;
            this.GenBtn.Click += new System.EventHandler(this.GenBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GenBtn);
            this.Controls.Add(this.EmpVer3);
            this.Controls.Add(this.EmpVer5);
            this.Controls.Add(this.EmpVer2);
            this.Controls.Add(this.EmpVer4);
            this.Controls.Add(this.chiLbl);
            this.Controls.Add(this.DLbl);
            this.Controls.Add(this.vibSredLbl);
            this.Controls.Add(this.EmpVer1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numEd);
            this.Controls.Add(this.Val1Ed5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Val1Ed4);
            this.Controls.Add(this.Val1Ed3);
            this.Controls.Add(this.Val1Ed2);
            this.Controls.Add(this.Val1Ed1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SizeNum);
            this.Controls.Add(this.VarianceNum);
            this.Controls.Add(this.MeanNum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MeanNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VarianceNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val1Ed1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val1Ed2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val1Ed3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val1Ed4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val1Ed5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown MeanNum;
        private System.Windows.Forms.NumericUpDown VarianceNum;
        private System.Windows.Forms.NumericUpDown SizeNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown Val1Ed1;
        private System.Windows.Forms.NumericUpDown Val1Ed2;
        private System.Windows.Forms.NumericUpDown Val1Ed3;
        private System.Windows.Forms.NumericUpDown Val1Ed4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown Val1Ed5;
        private System.Windows.Forms.NumericUpDown numEd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox EmpVer1;
        private System.Windows.Forms.TextBox vibSredLbl;
        private System.Windows.Forms.TextBox DLbl;
        private System.Windows.Forms.TextBox chiLbl;
        private System.Windows.Forms.TextBox EmpVer4;
        private System.Windows.Forms.TextBox EmpVer2;
        private System.Windows.Forms.TextBox EmpVer5;
        private System.Windows.Forms.TextBox EmpVer3;
        private System.Windows.Forms.Button GenBtn;
    }
}

