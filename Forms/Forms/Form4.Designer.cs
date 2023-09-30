namespace Forms
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.stop_bt = new System.Windows.Forms.Button();
            this.start_bt = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // stop_bt
            // 
            this.stop_bt.BackColor = System.Drawing.Color.Indigo;
            this.stop_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stop_bt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stop_bt.Location = new System.Drawing.Point(69, 273);
            this.stop_bt.Margin = new System.Windows.Forms.Padding(4);
            this.stop_bt.Name = "stop_bt";
            this.stop_bt.Size = new System.Drawing.Size(215, 38);
            this.stop_bt.TabIndex = 0;
            this.stop_bt.Text = "Зупинити";
            this.stop_bt.UseVisualStyleBackColor = false;
            this.stop_bt.Click += new System.EventHandler(this.Button1_Click);
            // 
            // start_bt
            // 
            this.start_bt.BackColor = System.Drawing.Color.Indigo;
            this.start_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_bt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.start_bt.Location = new System.Drawing.Point(321, 273);
            this.start_bt.Margin = new System.Windows.Forms.Padding(4);
            this.start_bt.Name = "start_bt";
            this.start_bt.Size = new System.Drawing.Size(215, 38);
            this.start_bt.TabIndex = 1;
            this.start_bt.Text = "Продовжити";
            this.start_bt.UseVisualStyleBackColor = false;
            this.start_bt.Click += new System.EventHandler(this.Button2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(32, 15);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(552, 238);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(616, 360);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.start_bt);
            this.Controls.Add(this.stop_bt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(800, 400);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Синусоїда";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button stop_bt;
        private System.Windows.Forms.Button start_bt;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}