namespace Tyuiu.BeketovVN.Sprint7.Project.V6
{
    partial class FormPatientCard_BVN
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartStats_BVN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxStats_BVN = new System.Windows.Forms.GroupBox();
            this.textBoxAvgTime_BVN = new System.Windows.Forms.TextBox();
            this.textBoxMaxTime_BVN = new System.Windows.Forms.TextBox();
            this.textBoxMinTime_BVN = new System.Windows.Forms.TextBox();
            this.textBoxPatientsTimes_BVN = new System.Windows.Forms.TextBox();
            this.labelAvgTime_BVN = new System.Windows.Forms.Label();
            this.labelMaxTime_BVN = new System.Windows.Forms.Label();
            this.labelMinTime_BVN = new System.Windows.Forms.Label();
            this.labelPatientsTimes_BVN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartStats_BVN)).BeginInit();
            this.groupBoxStats_BVN.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartStats_BVN
            // 
            this.chartStats_BVN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chartStats_BVN.ChartAreas.Add(chartArea1);
            this.chartStats_BVN.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.HeaderSeparatorColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            legend1.TitleSeparatorColor = System.Drawing.Color.White;
            this.chartStats_BVN.Legends.Add(legend1);
            this.chartStats_BVN.Location = new System.Drawing.Point(215, 0);
            this.chartStats_BVN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartStats_BVN.Name = "chartStats_BVN";
            series1.BackImageTransparentColor = System.Drawing.Color.White;
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.IsVisibleInLegend = false;
            series1.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartStats_BVN.Series.Add(series1);
            this.chartStats_BVN.Size = new System.Drawing.Size(854, 572);
            this.chartStats_BVN.TabIndex = 3;
            // 
            // groupBoxStats_BVN
            // 
            this.groupBoxStats_BVN.Controls.Add(this.textBoxAvgTime_BVN);
            this.groupBoxStats_BVN.Controls.Add(this.textBoxMaxTime_BVN);
            this.groupBoxStats_BVN.Controls.Add(this.textBoxMinTime_BVN);
            this.groupBoxStats_BVN.Controls.Add(this.textBoxPatientsTimes_BVN);
            this.groupBoxStats_BVN.Controls.Add(this.labelAvgTime_BVN);
            this.groupBoxStats_BVN.Controls.Add(this.labelMaxTime_BVN);
            this.groupBoxStats_BVN.Controls.Add(this.labelMinTime_BVN);
            this.groupBoxStats_BVN.Controls.Add(this.labelPatientsTimes_BVN);
            this.groupBoxStats_BVN.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxStats_BVN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxStats_BVN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.groupBoxStats_BVN.Location = new System.Drawing.Point(0, 0);
            this.groupBoxStats_BVN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxStats_BVN.Name = "groupBoxStats_BVN";
            this.groupBoxStats_BVN.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxStats_BVN.Size = new System.Drawing.Size(215, 572);
            this.groupBoxStats_BVN.TabIndex = 2;
            this.groupBoxStats_BVN.TabStop = false;
            this.groupBoxStats_BVN.Text = "Статистика";
            // 
            // textBoxAvgTime_BVN
            // 
            this.textBoxAvgTime_BVN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBoxAvgTime_BVN.Location = new System.Drawing.Point(16, 385);
            this.textBoxAvgTime_BVN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAvgTime_BVN.Name = "textBoxAvgTime_BVN";
            this.textBoxAvgTime_BVN.ReadOnly = true;
            this.textBoxAvgTime_BVN.Size = new System.Drawing.Size(165, 29);
            this.textBoxAvgTime_BVN.TabIndex = 7;
            // 
            // textBoxMaxTime_BVN
            // 
            this.textBoxMaxTime_BVN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBoxMaxTime_BVN.Location = new System.Drawing.Point(16, 305);
            this.textBoxMaxTime_BVN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMaxTime_BVN.Name = "textBoxMaxTime_BVN";
            this.textBoxMaxTime_BVN.ReadOnly = true;
            this.textBoxMaxTime_BVN.Size = new System.Drawing.Size(165, 29);
            this.textBoxMaxTime_BVN.TabIndex = 6;
            // 
            // textBoxMinTime_BVN
            // 
            this.textBoxMinTime_BVN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBoxMinTime_BVN.Location = new System.Drawing.Point(21, 206);
            this.textBoxMinTime_BVN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMinTime_BVN.Name = "textBoxMinTime_BVN";
            this.textBoxMinTime_BVN.ReadOnly = true;
            this.textBoxMinTime_BVN.Size = new System.Drawing.Size(165, 29);
            this.textBoxMinTime_BVN.TabIndex = 5;
            // 
            // textBoxPatientsTimes_BVN
            // 
            this.textBoxPatientsTimes_BVN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBoxPatientsTimes_BVN.Location = new System.Drawing.Point(21, 97);
            this.textBoxPatientsTimes_BVN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPatientsTimes_BVN.Name = "textBoxPatientsTimes_BVN";
            this.textBoxPatientsTimes_BVN.ReadOnly = true;
            this.textBoxPatientsTimes_BVN.Size = new System.Drawing.Size(165, 29);
            this.textBoxPatientsTimes_BVN.TabIndex = 4;
            // 
            // labelAvgTime_BVN
            // 
            this.labelAvgTime_BVN.AutoSize = true;
            this.labelAvgTime_BVN.Location = new System.Drawing.Point(17, 359);
            this.labelAvgTime_BVN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAvgTime_BVN.Name = "labelAvgTime_BVN";
            this.labelAvgTime_BVN.Size = new System.Drawing.Size(151, 24);
            this.labelAvgTime_BVN.TabIndex = 3;
            this.labelAvgTime_BVN.Text = "Среднее время";
            // 
            // labelMaxTime_BVN
            // 
            this.labelMaxTime_BVN.AutoSize = true;
            this.labelMaxTime_BVN.Location = new System.Drawing.Point(3, 257);
            this.labelMaxTime_BVN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaxTime_BVN.Name = "labelMaxTime_BVN";
            this.labelMaxTime_BVN.Size = new System.Drawing.Size(202, 48);
            this.labelMaxTime_BVN.TabIndex = 2;
            this.labelMaxTime_BVN.Text = "Максимальный срок\r\nнетрудоспособности";
            this.labelMaxTime_BVN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMinTime_BVN
            // 
            this.labelMinTime_BVN.AutoSize = true;
            this.labelMinTime_BVN.Location = new System.Drawing.Point(3, 158);
            this.labelMinTime_BVN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinTime_BVN.Name = "labelMinTime_BVN";
            this.labelMinTime_BVN.Size = new System.Drawing.Size(202, 48);
            this.labelMinTime_BVN.TabIndex = 1;
            this.labelMinTime_BVN.Text = "Минимальный срок\r\nнетрудоспособности";
            this.labelMinTime_BVN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPatientsTimes_BVN
            // 
            this.labelPatientsTimes_BVN.AutoSize = true;
            this.labelPatientsTimes_BVN.Location = new System.Drawing.Point(47, 71);
            this.labelPatientsTimes_BVN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPatientsTimes_BVN.Name = "labelPatientsTimes_BVN";
            this.labelPatientsTimes_BVN.Size = new System.Drawing.Size(100, 24);
            this.labelPatientsTimes_BVN.TabIndex = 0;
            this.labelPatientsTimes_BVN.Text = "Раз болел";
            // 
            // FormPatientCard_BVN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1069, 572);
            this.Controls.Add(this.chartStats_BVN);
            this.Controls.Add(this.groupBoxStats_BVN);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(746, 468);
            this.Name = "FormPatientCard_BVN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пациент ";
            this.Load += new System.EventHandler(this.FormPatientCard_BVN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartStats_BVN)).EndInit();
            this.groupBoxStats_BVN.ResumeLayout(false);
            this.groupBoxStats_BVN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStats_BVN;
        private System.Windows.Forms.GroupBox groupBoxStats_BVN;
        private System.Windows.Forms.TextBox textBoxAvgTime_BVN;
        private System.Windows.Forms.TextBox textBoxMaxTime_BVN;
        private System.Windows.Forms.TextBox textBoxMinTime_BVN;
        private System.Windows.Forms.TextBox textBoxPatientsTimes_BVN;
        private System.Windows.Forms.Label labelAvgTime_BVN;
        private System.Windows.Forms.Label labelMaxTime_BVN;
        private System.Windows.Forms.Label labelMinTime_BVN;
        private System.Windows.Forms.Label labelPatientsTimes_BVN;
    }
}