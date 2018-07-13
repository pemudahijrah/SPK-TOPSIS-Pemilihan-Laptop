namespace Spk1
{
    partial class frmutama
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnabout = new System.Windows.Forms.Button();
            this.btnbantuan = new System.Windows.Forms.Button();
            this.btnmulai = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aplikasi SPK Pemilihan Laptop Dengan Metode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "TOPSIS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.btnabout);
            this.panel1.Controls.Add(this.btnbantuan);
            this.panel1.Controls.Add(this.btnmulai);
            this.panel1.Location = new System.Drawing.Point(48, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 180);
            this.panel1.TabIndex = 6;
            // 
            // btnexit
            // 
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnexit.Location = new System.Drawing.Point(113, 140);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(78, 23);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnabout
            // 
            this.btnabout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnabout.Location = new System.Drawing.Point(113, 99);
            this.btnabout.Name = "btnabout";
            this.btnabout.Size = new System.Drawing.Size(78, 23);
            this.btnabout.TabIndex = 8;
            this.btnabout.Text = "About";
            this.btnabout.UseVisualStyleBackColor = true;
            this.btnabout.Click += new System.EventHandler(this.btnabout_Click);
            // 
            // btnbantuan
            // 
            this.btnbantuan.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnbantuan.Location = new System.Drawing.Point(113, 58);
            this.btnbantuan.Name = "btnbantuan";
            this.btnbantuan.Size = new System.Drawing.Size(78, 23);
            this.btnbantuan.TabIndex = 7;
            this.btnbantuan.Text = "Bantuan";
            this.btnbantuan.UseVisualStyleBackColor = true;
            this.btnbantuan.Click += new System.EventHandler(this.btnbantuan_Click);
            // 
            // btnmulai
            // 
            this.btnmulai.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnmulai.Location = new System.Drawing.Point(113, 18);
            this.btnmulai.Name = "btnmulai";
            this.btnmulai.Size = new System.Drawing.Size(78, 23);
            this.btnmulai.TabIndex = 6;
            this.btnmulai.Text = "Mulai";
            this.btnmulai.UseVisualStyleBackColor = true;
            this.btnmulai.Click += new System.EventHandler(this.btnmulai_Click);
            // 
            // frmutama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(414, 292);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmutama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPK";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnabout;
        private System.Windows.Forms.Button btnbantuan;
        private System.Windows.Forms.Button btnmulai;
    }
}

