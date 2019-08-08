namespace Number5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtordernumber = new System.Windows.Forms.TextBox();
            this.txtcustomername = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChkBlack = new System.Windows.Forms.CheckBox();
            this.ChkRed = new System.Windows.Forms.CheckBox();
            this.ChkBlue = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.QtyBlack = new System.Windows.Forms.TextBox();
            this.Btnreset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.QtyRed = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.QtyBlue = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Shipping Address:";
            // 
            // txtordernumber
            // 
            this.txtordernumber.Location = new System.Drawing.Point(101, 15);
            this.txtordernumber.Name = "txtordernumber";
            this.txtordernumber.Size = new System.Drawing.Size(187, 20);
            this.txtordernumber.TabIndex = 3;
            // 
            // txtcustomername
            // 
            this.txtcustomername.Location = new System.Drawing.Point(101, 59);
            this.txtcustomername.Name = "txtcustomername";
            this.txtcustomername.Size = new System.Drawing.Size(187, 20);
            this.txtcustomername.TabIndex = 4;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(101, 101);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(187, 20);
            this.txtaddress.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtaddress);
            this.panel1.Controls.Add(this.txtcustomername);
            this.panel1.Controls.Add(this.txtordernumber);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 147);
            this.panel1.TabIndex = 6;
            // 
            // ChkBlack
            // 
            this.ChkBlack.AutoSize = true;
            this.ChkBlack.Location = new System.Drawing.Point(222, 40);
            this.ChkBlack.Name = "ChkBlack";
            this.ChkBlack.Size = new System.Drawing.Size(53, 17);
            this.ChkBlack.TabIndex = 7;
            this.ChkBlack.Text = "Black";
            this.ChkBlack.UseVisualStyleBackColor = true;
            // 
            // ChkRed
            // 
            this.ChkRed.AutoSize = true;
            this.ChkRed.Location = new System.Drawing.Point(222, 103);
            this.ChkRed.Name = "ChkRed";
            this.ChkRed.Size = new System.Drawing.Size(46, 17);
            this.ChkRed.TabIndex = 8;
            this.ChkRed.Text = "Red";
            this.ChkRed.UseVisualStyleBackColor = true;
            // 
            // ChkBlue
            // 
            this.ChkBlue.AutoSize = true;
            this.ChkBlue.Location = new System.Drawing.Point(222, 71);
            this.ChkBlue.Name = "ChkBlue";
            this.ChkBlue.Size = new System.Drawing.Size(47, 17);
            this.ChkBlue.TabIndex = 9;
            this.ChkBlue.Text = "Blue";
            this.ChkBlue.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quantity:";
            // 
            // QtyBlack
            // 
            this.QtyBlack.Location = new System.Drawing.Point(72, 37);
            this.QtyBlack.Name = "QtyBlack";
            this.QtyBlack.Size = new System.Drawing.Size(139, 20);
            this.QtyBlack.TabIndex = 11;
            // 
            // Btnreset
            // 
            this.Btnreset.Location = new System.Drawing.Point(526, 221);
            this.Btnreset.Name = "Btnreset";
            this.Btnreset.Size = new System.Drawing.Size(129, 29);
            this.Btnreset.TabIndex = 12;
            this.Btnreset.Text = "Reset";
            this.Btnreset.UseVisualStyleBackColor = true;
            this.Btnreset.Click += new System.EventHandler(this.Btnreset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total Tax:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Shiping Cost:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Total Cost:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.QtyRed);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.QtyBlue);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.QtyBlack);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.ChkBlue);
            this.panel2.Controls.Add(this.ChkRed);
            this.panel2.Controls.Add(this.ChkBlack);
            this.panel2.Location = new System.Drawing.Point(329, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 144);
            this.panel2.TabIndex = 17;
            // 
            // QtyRed
            // 
            this.QtyRed.Location = new System.Drawing.Point(72, 101);
            this.QtyRed.Name = "QtyRed";
            this.QtyRed.Size = new System.Drawing.Size(139, 20);
            this.QtyRed.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Quantity:";
            // 
            // QtyBlue
            // 
            this.QtyBlue.Location = new System.Drawing.Point(72, 69);
            this.QtyBlue.Name = "QtyBlue";
            this.QtyBlue.Size = new System.Drawing.Size(139, 20);
            this.QtyBlue.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Quantity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(100, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "label7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(99, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(95, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "label10";
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(400, 219);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(120, 29);
            this.BtnCalculate.TabIndex = 21;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(100, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 18);
            this.label13.TabIndex = 22;
            this.label13.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(98, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 18);
            this.label14.TabIndex = 23;
            this.label14.Text = "label14";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(100, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 18);
            this.label15.TabIndex = 24;
            this.label15.Text = "label15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(99, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 18);
            this.label16.TabIndex = 25;
            this.label16.Text = "label16";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Total Red:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 27;
            this.label18.Text = "Total Blue:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(19, 83);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 13);
            this.label19.TabIndex = 28;
            this.label19.Text = "Total Black:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 82);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 13);
            this.label20.TabIndex = 29;
            this.label20.Text = "SubTotal:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(13, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 150);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(208, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 122);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 355);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Btnreset);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Fuzzy Dice";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtordernumber;
        private System.Windows.Forms.TextBox txtcustomername;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ChkBlack;
        private System.Windows.Forms.CheckBox ChkRed;
        private System.Windows.Forms.CheckBox ChkBlue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox QtyBlack;
        private System.Windows.Forms.Button Btnreset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.TextBox QtyRed;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox QtyBlue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

