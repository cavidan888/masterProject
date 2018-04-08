namespace C_Sharp_Wide_App
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.adinSec = new System.Windows.Forms.Button();
            this.newCustomer = new System.Windows.Forms.Button();
            this.Rooms = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cstBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adinSec
            // 
            this.adinSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.adinSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adinSec.Location = new System.Drawing.Point(110, 67);
            this.adinSec.Name = "adinSec";
            this.adinSec.Size = new System.Drawing.Size(142, 81);
            this.adinSec.TabIndex = 0;
            this.adinSec.Text = "Admin Section";
            this.adinSec.UseVisualStyleBackColor = false;
            this.adinSec.Click += new System.EventHandler(this.adinSec_Click);
            // 
            // newCustomer
            // 
            this.newCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.newCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCustomer.Location = new System.Drawing.Point(327, 67);
            this.newCustomer.Name = "newCustomer";
            this.newCustomer.Size = new System.Drawing.Size(142, 81);
            this.newCustomer.TabIndex = 0;
            this.newCustomer.Text = "New Customer";
            this.newCustomer.UseVisualStyleBackColor = false;
            this.newCustomer.Click += new System.EventHandler(this.newCustomer_Click);
            // 
            // Rooms
            // 
            this.Rooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rooms.Location = new System.Drawing.Point(532, 67);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(142, 81);
            this.Rooms.TabIndex = 0;
            this.Rooms.Text = "Rooms";
            this.Rooms.UseVisualStyleBackColor = false;
            this.Rooms.Click += new System.EventHandler(this.Rooms_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(327, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "New Customer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.newCustomer_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(532, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 81);
            this.button2.TabIndex = 0;
            this.button2.Text = "Rooms";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Rooms_Click);
            // 
            // cstBtn
            // 
            this.cstBtn.BackColor = System.Drawing.Color.Olive;
            this.cstBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cstBtn.Location = new System.Drawing.Point(110, 205);
            this.cstBtn.Name = "cstBtn";
            this.cstBtn.Size = new System.Drawing.Size(142, 81);
            this.cstBtn.TabIndex = 1;
            this.cstBtn.Text = "Customers";
            this.cstBtn.UseVisualStyleBackColor = false;
            this.cstBtn.Click += new System.EventHandler(this.cstBtn_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cstBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Rooms);
            this.Controls.Add(this.newCustomer);
            this.Controls.Add(this.adinSec);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adinSec;
        private System.Windows.Forms.Button newCustomer;
        private System.Windows.Forms.Button Rooms;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cstBtn;
    }
}