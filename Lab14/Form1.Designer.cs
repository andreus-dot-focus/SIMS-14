
namespace Lab14
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Mean = new System.Windows.Forms.NumericUpDown();
            this.Variance = new System.Windows.Forms.NumericUpDown();
            this.Sam_size = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Start = new System.Windows.Forms.Button();
            this.Average = new System.Windows.Forms.TextBox();
            this.Var = new System.Windows.Forms.TextBox();
            this.Ave_err = new System.Windows.Forms.TextBox();
            this.Var_err = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Mean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Variance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sam_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(53, 212);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mean";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(53, 272);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Variance";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(53, 334);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sample size";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(707, 754);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Average";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(707, 814);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Variance";
            // 
            // Mean
            // 
            this.Mean.DecimalPlaces = 2;
            this.Mean.Location = new System.Drawing.Point(244, 203);
            this.Mean.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mean.Name = "Mean";
            this.Mean.Size = new System.Drawing.Size(154, 26);
            this.Mean.TabIndex = 6;
            this.Mean.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            this.Mean.ValueChanged += new System.EventHandler(this.Mean_ValueChanged);
            // 
            // Variance
            // 
            this.Variance.DecimalPlaces = 2;
            this.Variance.Location = new System.Drawing.Point(244, 263);
            this.Variance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Variance.Name = "Variance";
            this.Variance.Size = new System.Drawing.Size(154, 26);
            this.Variance.TabIndex = 7;
            this.Variance.Value = new decimal(new int[] {
            45,
            0,
            0,
            131072});
            this.Variance.ValueChanged += new System.EventHandler(this.Variance_ValueChanged);
            // 
            // Sam_size
            // 
            this.Sam_size.Location = new System.Drawing.Point(244, 325);
            this.Sam_size.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sam_size.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.Sam_size.Name = "Sam_size";
            this.Sam_size.Size = new System.Drawing.Size(154, 26);
            this.Sam_size.TabIndex = 8;
            this.Sam_size.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Sam_size.ValueChanged += new System.EventHandler(this.Sam_size_ValueChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(481, 18);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.CornflowerBlue;
            series1.Legend = "Legend1";
            series1.Name = "freq";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.MarkerBorderWidth = 3;
            series2.MarkerColor = System.Drawing.Color.White;
            series2.Name = "distr";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(941, 688);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Start.Location = new System.Drawing.Point(140, 592);
            this.Start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(166, 92);
            this.Start.TabIndex = 10;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Average
            // 
            this.Average.Location = new System.Drawing.Point(852, 749);
            this.Average.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(127, 26);
            this.Average.TabIndex = 11;
            // 
            // Var
            // 
            this.Var.Location = new System.Drawing.Point(852, 805);
            this.Var.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Var.Name = "Var";
            this.Var.Size = new System.Drawing.Size(127, 26);
            this.Var.TabIndex = 12;
            // 
            // Ave_err
            // 
            this.Ave_err.Location = new System.Drawing.Point(1018, 749);
            this.Ave_err.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Ave_err.Name = "Ave_err";
            this.Ave_err.Size = new System.Drawing.Size(127, 26);
            this.Ave_err.TabIndex = 14;
            // 
            // Var_err
            // 
            this.Var_err.Location = new System.Drawing.Point(1018, 803);
            this.Var_err.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Var_err.Name = "Var_err";
            this.Var_err.Size = new System.Drawing.Size(127, 26);
            this.Var_err.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1437, 877);
            this.Controls.Add(this.Var_err);
            this.Controls.Add(this.Ave_err);
            this.Controls.Add(this.Var);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Sam_size);
            this.Controls.Add(this.Variance);
            this.Controls.Add(this.Mean);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Mean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Variance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sam_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Mean;
        private System.Windows.Forms.NumericUpDown Variance;
        private System.Windows.Forms.NumericUpDown Sam_size;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox Average;
        private System.Windows.Forms.TextBox Var;
        private System.Windows.Forms.TextBox Ave_err;
        private System.Windows.Forms.TextBox Var_err;
    }
}

