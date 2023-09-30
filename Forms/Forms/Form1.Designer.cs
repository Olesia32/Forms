namespace Forms
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stop_bt = new System.Windows.Forms.Button();
            this.start_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(28, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // stop_bt
            // 
            this.stop_bt.BackColor = System.Drawing.Color.Indigo;
            this.stop_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stop_bt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stop_bt.Location = new System.Drawing.Point(28, 297);
            this.stop_bt.Margin = new System.Windows.Forms.Padding(4);
            this.stop_bt.Name = "stop_bt";
            this.stop_bt.Size = new System.Drawing.Size(186, 38);
            this.stop_bt.TabIndex = 2;
            this.stop_bt.Text = "Зупинити";
            this.stop_bt.UseVisualStyleBackColor = false;
            this.stop_bt.Click += new System.EventHandler(this.StopAnimationButton_Click);
            // 
            // start_bt
            // 
            this.start_bt.BackColor = System.Drawing.Color.Indigo;
            this.start_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_bt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.start_bt.Location = new System.Drawing.Point(222, 297);
            this.start_bt.Margin = new System.Windows.Forms.Padding(4);
            this.start_bt.Name = "start_bt";
            this.start_bt.Size = new System.Drawing.Size(186, 38);
            this.start_bt.TabIndex = 3;
            this.start_bt.Text = "Продовжити";
            this.start_bt.UseVisualStyleBackColor = false;
            this.start_bt.Click += new System.EventHandler(this.StartAnimationButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(457, 360);
            this.Controls.Add(this.start_bt);
            this.Controls.Add(this.stop_bt);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(200, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Трикутник";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button stop_bt;
        private System.Windows.Forms.Button start_bt;
    }
}

