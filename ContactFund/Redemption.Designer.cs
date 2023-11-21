namespace ContactFund
{
    partial class Redemption
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txticava = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtredic = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnrun = new System.Windows.Forms.Button();
            this.txtic = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtredemption = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Redemption";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Available IC balance";
            // 
            // txticava
            // 
            this.txticava.Enabled = false;
            this.txticava.Location = new System.Drawing.Point(179, 202);
            this.txticava.Name = "txticava";
            this.txticava.Size = new System.Drawing.Size(143, 22);
            this.txticava.TabIndex = 12;
            this.txticava.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtname
            // 
            this.txtname.Enabled = false;
            this.txtname.Location = new System.Drawing.Point(179, 88);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(143, 22);
            this.txtname.TabIndex = 11;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(179, 56);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(143, 22);
            this.txtid.TabIndex = 13;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sett date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Trade date";
            // 
            // txtredic
            // 
            this.txtredic.Location = new System.Drawing.Point(179, 358);
            this.txtredic.Name = "txtredic";
            this.txtredic.Size = new System.Drawing.Size(143, 22);
            this.txtredic.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "IC Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Locked Today";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(341, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(472, 32);
            this.label9.TabIndex = 21;
            this.label9.Text = "Ideally, automate settlemet date to the current day between 9:00 am - 11:00 am. \r" +
    "\nand to the next working day after 11:00 am";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(341, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(382, 48);
            this.label10.TabIndex = 22;
            this.label10.Text = "IC holding balance \r\nIncluding (Less) pending redemption order (not confirmed by " +
    "CI)\r\nexcluding (not adding) pending orders (not confirmed by CI)\r\n";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(179, 275);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(143, 22);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(179, 316);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(143, 22);
            this.dateTimePicker2.TabIndex = 24;
            // 
            // btnrun
            // 
            this.btnrun.Location = new System.Drawing.Point(179, 406);
            this.btnrun.Name = "btnrun";
            this.btnrun.Size = new System.Drawing.Size(143, 23);
            this.btnrun.TabIndex = 40;
            this.btnrun.Text = "Run";
            this.btnrun.UseVisualStyleBackColor = true;
            this.btnrun.Click += new System.EventHandler(this.btnrun_Click);
            // 
            // txtic
            // 
            this.txtic.Enabled = false;
            this.txtic.Location = new System.Drawing.Point(179, 126);
            this.txtic.Name = "txtic";
            this.txtic.Size = new System.Drawing.Size(143, 22);
            this.txtic.TabIndex = 42;
            this.txtic.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 41;
            this.label11.Text = "IC Holding";
            // 
            // txtredemption
            // 
            this.txtredemption.Enabled = false;
            this.txtredemption.Location = new System.Drawing.Point(179, 164);
            this.txtredemption.Name = "txtredemption";
            this.txtredemption.Size = new System.Drawing.Size(143, 22);
            this.txtredemption.TabIndex = 44;
            this.txtredemption.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 16);
            this.label12.TabIndex = 43;
            this.label12.Text = "Pending Redemption";
            // 
            // Redemption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 450);
            this.Controls.Add(this.txtredemption);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtic);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnrun);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtredic);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txticava);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Redemption";
            this.Text = "Redemption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txticava;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtredic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnrun;
        private System.Windows.Forms.TextBox txtic;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtredemption;
        private System.Windows.Forms.Label label12;
    }
}