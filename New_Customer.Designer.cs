namespace C_Sharp_Wide_App
{
    partial class New_Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Customer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.saveCust = new System.Windows.Forms.Button();
            this.dtPickerExit = new System.Windows.Forms.DateTimePicker();
            this.dtPickrEnter = new System.Windows.Forms.DateTimePicker();
            this.mskTxTPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtSurName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.txtPNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.room101 = new System.Windows.Forms.GroupBox();
            this.room109 = new System.Windows.Forms.Button();
            this.room106 = new System.Windows.Forms.Button();
            this.room103 = new System.Windows.Forms.Button();
            this.room105 = new System.Windows.Forms.Button();
            this.room108 = new System.Windows.Forms.Button();
            this.room102 = new System.Windows.Forms.Button();
            this.room107 = new System.Windows.Forms.Button();
            this.room104 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.butonExampleFull = new System.Windows.Forms.Button();
            this.butonExampleeMPTY = new System.Windows.Forms.Button();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.room101.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.genderBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.saveCust);
            this.groupBox1.Controls.Add(this.dtPickerExit);
            this.groupBox1.Controls.Add(this.dtPickrEnter);
            this.groupBox1.Controls.Add(this.mskTxTPhone);
            this.groupBox1.Controls.Add(this.txtSurName);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.txtRoomNo);
            this.groupBox1.Controls.Add(this.txtPNo);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lb2);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 397);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Info";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(462, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "0";
            // 
            // saveCust
            // 
            this.saveCust.BackColor = System.Drawing.Color.Yellow;
            this.saveCust.Location = new System.Drawing.Point(306, 345);
            this.saveCust.Name = "saveCust";
            this.saveCust.Size = new System.Drawing.Size(92, 30);
            this.saveCust.TabIndex = 22;
            this.saveCust.Text = "Save";
            this.saveCust.UseVisualStyleBackColor = false;
            this.saveCust.Click += new System.EventHandler(this.saveCust_Click);
            // 
            // dtPickerExit
            // 
            this.dtPickerExit.Location = new System.Drawing.Point(130, 309);
            this.dtPickerExit.Name = "dtPickerExit";
            this.dtPickerExit.Size = new System.Drawing.Size(268, 21);
            this.dtPickerExit.TabIndex = 21;
            this.dtPickerExit.ValueChanged += new System.EventHandler(this.dtPickerExit_ValueChanged);
            // 
            // dtPickrEnter
            // 
            this.dtPickrEnter.Location = new System.Drawing.Point(130, 274);
            this.dtPickrEnter.Name = "dtPickrEnter";
            this.dtPickrEnter.Size = new System.Drawing.Size(268, 21);
            this.dtPickrEnter.TabIndex = 20;
            // 
            // mskTxTPhone
            // 
            this.mskTxTPhone.Location = new System.Drawing.Point(130, 123);
            this.mskTxTPhone.Mask = "(999) 000-0000";
            this.mskTxTPhone.Name = "mskTxTPhone";
            this.mskTxTPhone.Size = new System.Drawing.Size(246, 21);
            this.mskTxTPhone.TabIndex = 19;
            // 
            // txtSurName
            // 
            this.txtSurName.Location = new System.Drawing.Point(130, 91);
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.Size = new System.Drawing.Size(246, 21);
            this.txtSurName.TabIndex = 18;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(130, 181);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(246, 21);
            this.txtPrice.TabIndex = 17;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(130, 152);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(246, 21);
            this.txtMail.TabIndex = 16;
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Location = new System.Drawing.Point(130, 239);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(246, 21);
            this.txtRoomNo.TabIndex = 15;
            // 
            // txtPNo
            // 
            this.txtPNo.Location = new System.Drawing.Point(130, 208);
            this.txtPNo.Name = "txtPNo";
            this.txtPNo.Size = new System.Drawing.Size(246, 21);
            this.txtPNo.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(246, 21);
            this.txtName.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Exit Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Room No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Personal No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phone";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(37, 91);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(67, 15);
            this.lb2.TabIndex = 7;
            this.lb2.Text = "SurName";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(56, 55);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(45, 15);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "Name";
            // 
            // room101
            // 
            this.room101.Controls.Add(this.room109);
            this.room101.Controls.Add(this.room106);
            this.room101.Controls.Add(this.room103);
            this.room101.Controls.Add(this.room105);
            this.room101.Controls.Add(this.room108);
            this.room101.Controls.Add(this.room102);
            this.room101.Controls.Add(this.room107);
            this.room101.Controls.Add(this.room104);
            this.room101.Controls.Add(this.button1);
            this.room101.Location = new System.Drawing.Point(651, 43);
            this.room101.Name = "room101";
            this.room101.Size = new System.Drawing.Size(549, 397);
            this.room101.TabIndex = 1;
            this.room101.TabStop = false;
            this.room101.Text = "Rooms";
            // 
            // room109
            // 
            this.room109.BackColor = System.Drawing.Color.YellowGreen;
            this.room109.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room109.Location = new System.Drawing.Point(412, 248);
            this.room109.Name = "room109";
            this.room109.Size = new System.Drawing.Size(71, 41);
            this.room109.TabIndex = 8;
            this.room109.Text = "109";
            this.room109.UseVisualStyleBackColor = false;
            this.room109.Click += new System.EventHandler(this.room109_Click);
            // 
            // room106
            // 
            this.room106.BackColor = System.Drawing.Color.YellowGreen;
            this.room106.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room106.Location = new System.Drawing.Point(412, 182);
            this.room106.Name = "room106";
            this.room106.Size = new System.Drawing.Size(71, 42);
            this.room106.TabIndex = 7;
            this.room106.Text = "106";
            this.room106.UseVisualStyleBackColor = false;
            this.room106.Click += new System.EventHandler(this.room106_Click);
            // 
            // room103
            // 
            this.room103.BackColor = System.Drawing.Color.YellowGreen;
            this.room103.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room103.Location = new System.Drawing.Point(412, 122);
            this.room103.Name = "room103";
            this.room103.Size = new System.Drawing.Size(71, 42);
            this.room103.TabIndex = 6;
            this.room103.Text = "103";
            this.room103.UseVisualStyleBackColor = false;
            this.room103.Click += new System.EventHandler(this.room103_Click);
            // 
            // room105
            // 
            this.room105.BackColor = System.Drawing.Color.YellowGreen;
            this.room105.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room105.Location = new System.Drawing.Point(249, 182);
            this.room105.Name = "room105";
            this.room105.Size = new System.Drawing.Size(71, 42);
            this.room105.TabIndex = 5;
            this.room105.Text = "105";
            this.room105.UseVisualStyleBackColor = false;
            this.room105.Click += new System.EventHandler(this.room105_Click);
            // 
            // room108
            // 
            this.room108.BackColor = System.Drawing.Color.YellowGreen;
            this.room108.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room108.Location = new System.Drawing.Point(249, 249);
            this.room108.Name = "room108";
            this.room108.Size = new System.Drawing.Size(71, 39);
            this.room108.TabIndex = 4;
            this.room108.Text = "108";
            this.room108.UseVisualStyleBackColor = false;
            this.room108.Click += new System.EventHandler(this.room108_Click);
            // 
            // room102
            // 
            this.room102.BackColor = System.Drawing.Color.YellowGreen;
            this.room102.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room102.Location = new System.Drawing.Point(249, 122);
            this.room102.Name = "room102";
            this.room102.Size = new System.Drawing.Size(71, 42);
            this.room102.TabIndex = 3;
            this.room102.Text = "102";
            this.room102.UseVisualStyleBackColor = false;
            this.room102.Click += new System.EventHandler(this.room102_Click);
            // 
            // room107
            // 
            this.room107.BackColor = System.Drawing.Color.YellowGreen;
            this.room107.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room107.Location = new System.Drawing.Point(78, 245);
            this.room107.Name = "room107";
            this.room107.Size = new System.Drawing.Size(71, 39);
            this.room107.TabIndex = 2;
            this.room107.Text = "107";
            this.room107.UseVisualStyleBackColor = false;
            this.room107.Click += new System.EventHandler(this.room107_Click);
            // 
            // room104
            // 
            this.room104.BackColor = System.Drawing.Color.YellowGreen;
            this.room104.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room104.Location = new System.Drawing.Point(78, 182);
            this.room104.Name = "room104";
            this.room104.Size = new System.Drawing.Size(71, 42);
            this.room104.TabIndex = 1;
            this.room104.Text = "104";
            this.room104.UseVisualStyleBackColor = false;
            this.room104.Click += new System.EventHandler(this.room104_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(78, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "101";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butonExampleFull
            // 
            this.butonExampleFull.BackColor = System.Drawing.Color.Red;
            this.butonExampleFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonExampleFull.Location = new System.Drawing.Point(862, 464);
            this.butonExampleFull.Name = "butonExampleFull";
            this.butonExampleFull.Size = new System.Drawing.Size(71, 42);
            this.butonExampleFull.TabIndex = 0;
            this.butonExampleFull.Text = "Full";
            this.butonExampleFull.UseVisualStyleBackColor = false;
            this.butonExampleFull.Click += new System.EventHandler(this.butonExampleFull_Click);
            // 
            // butonExampleeMPTY
            // 
            this.butonExampleeMPTY.BackColor = System.Drawing.Color.YellowGreen;
            this.butonExampleeMPTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonExampleeMPTY.Location = new System.Drawing.Point(955, 464);
            this.butonExampleeMPTY.Name = "butonExampleeMPTY";
            this.butonExampleeMPTY.Size = new System.Drawing.Size(71, 42);
            this.butonExampleeMPTY.TabIndex = 0;
            this.butonExampleeMPTY.Text = "Empty";
            this.butonExampleeMPTY.UseVisualStyleBackColor = false;
            this.butonExampleeMPTY.Click += new System.EventHandler(this.butonExampleeMPTY_Click);
            // 
            // genderBox
            // 
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Location = new System.Drawing.Point(130, 345);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(121, 23);
            this.genderBox.TabIndex = 27;
            // 
            // New_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1257, 518);
            this.Controls.Add(this.room101);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butonExampleeMPTY);
            this.Controls.Add(this.butonExampleFull);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "New_Customer";
            this.Text = "Add New Customer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.room101.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.MaskedTextBox mskTxTPhone;
        private System.Windows.Forms.TextBox txtSurName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button saveCust;
        private System.Windows.Forms.DateTimePicker dtPickerExit;
        private System.Windows.Forms.DateTimePicker dtPickrEnter;
        private System.Windows.Forms.GroupBox room101;
        private System.Windows.Forms.Button room109;
        private System.Windows.Forms.Button room106;
        private System.Windows.Forms.Button room103;
        private System.Windows.Forms.Button room105;
        private System.Windows.Forms.Button room108;
        private System.Windows.Forms.Button room102;
        private System.Windows.Forms.Button room107;
        private System.Windows.Forms.Button room104;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butonExampleFull;
        private System.Windows.Forms.Button butonExampleeMPTY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox genderBox;
    }
}