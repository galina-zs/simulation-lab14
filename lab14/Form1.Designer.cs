namespace lab14
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.meanLabel = new System.Windows.Forms.Label();
            this.varianceInputLabel = new System.Windows.Forms.Label();
            this.meanNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.varianceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberOfExperimentsLabel = new System.Windows.Forms.Label();
            this.numberOfExperimentsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meanNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varianceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfExperimentsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(267, 24);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(628, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // meanLabel
            // 
            this.meanLabel.AutoSize = true;
            this.meanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.meanLabel.Location = new System.Drawing.Point(29, 53);
            this.meanLabel.Name = "meanLabel";
            this.meanLabel.Size = new System.Drawing.Size(49, 20);
            this.meanLabel.TabIndex = 1;
            this.meanLabel.Text = "Mean";
            // 
            // varianceInputLabel
            // 
            this.varianceInputLabel.AutoSize = true;
            this.varianceInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.varianceInputLabel.Location = new System.Drawing.Point(29, 99);
            this.varianceInputLabel.Name = "varianceInputLabel";
            this.varianceInputLabel.Size = new System.Drawing.Size(72, 20);
            this.varianceInputLabel.TabIndex = 2;
            this.varianceInputLabel.Text = "Variance";
            // 
            // meanNumericUpDown
            // 
            this.meanNumericUpDown.DecimalPlaces = 3;
            this.meanNumericUpDown.Location = new System.Drawing.Point(122, 53);
            this.meanNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.meanNumericUpDown.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.meanNumericUpDown.Name = "meanNumericUpDown";
            this.meanNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.meanNumericUpDown.TabIndex = 3;
            // 
            // varianceNumericUpDown
            // 
            this.varianceNumericUpDown.DecimalPlaces = 3;
            this.varianceNumericUpDown.Location = new System.Drawing.Point(122, 99);
            this.varianceNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.varianceNumericUpDown.Name = "varianceNumericUpDown";
            this.varianceNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.varianceNumericUpDown.TabIndex = 4;
            // 
            // numberOfExperimentsLabel
            // 
            this.numberOfExperimentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberOfExperimentsLabel.Location = new System.Drawing.Point(12, 143);
            this.numberOfExperimentsLabel.Name = "numberOfExperimentsLabel";
            this.numberOfExperimentsLabel.Size = new System.Drawing.Size(97, 48);
            this.numberOfExperimentsLabel.TabIndex = 5;
            this.numberOfExperimentsLabel.Text = "Number of experiments";
            // 
            // numberOfExperimentsNumericUpDown
            // 
            this.numberOfExperimentsNumericUpDown.Location = new System.Drawing.Point(122, 162);
            this.numberOfExperimentsNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numberOfExperimentsNumericUpDown.Name = "numberOfExperimentsNumericUpDown";
            this.numberOfExperimentsNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.numberOfExperimentsNumericUpDown.TabIndex = 6;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(167, 214);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 450);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.numberOfExperimentsNumericUpDown);
            this.Controls.Add(this.numberOfExperimentsLabel);
            this.Controls.Add(this.varianceNumericUpDown);
            this.Controls.Add(this.meanNumericUpDown);
            this.Controls.Add(this.varianceInputLabel);
            this.Controls.Add(this.meanLabel);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meanNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varianceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfExperimentsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label meanLabel;
        private System.Windows.Forms.Label varianceInputLabel;
        private System.Windows.Forms.NumericUpDown meanNumericUpDown;
        private System.Windows.Forms.NumericUpDown varianceNumericUpDown;
        private System.Windows.Forms.Label numberOfExperimentsLabel;
        private System.Windows.Forms.NumericUpDown numberOfExperimentsNumericUpDown;
        private System.Windows.Forms.Button startButton;
    }
}

