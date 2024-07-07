namespace prop_finder
{
    partial class Login_form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.login_panel = new System.Windows.Forms.Panel();
            this.Rentee_sign_panel = new System.Windows.Forms.Panel();
            this.Login_lbl = new System.Windows.Forms.LinkLabel();
            this.lister_sign_lbl = new System.Windows.Forms.LinkLabel();
            this.sign_up_rentee = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.us_login_uc1 = new prop_finder.us_login_uc();
            this.lister_sign_up_signup1 = new prop_finder.lister_sign_up_signup();
            this.rentee_sign_up1 = new prop_finder.Rentee_sign_up();
            this.panel1.SuspendLayout();
            this.login_panel.SuspendLayout();
            this.Rentee_sign_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.login_panel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(220, 156);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1263, 730);
            this.panel1.TabIndex = 0;
            // 
            // login_panel
            // 
            this.login_panel.Controls.Add(this.Rentee_sign_panel);
            this.login_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.login_panel.Location = new System.Drawing.Point(592, 0);
            this.login_panel.Margin = new System.Windows.Forms.Padding(4);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(671, 730);
            this.login_panel.TabIndex = 1;
            // 
            // Rentee_sign_panel
            // 
            this.Rentee_sign_panel.Controls.Add(this.us_login_uc1);
            this.Rentee_sign_panel.Controls.Add(this.lister_sign_up_signup1);
            this.Rentee_sign_panel.Controls.Add(this.rentee_sign_up1);
            this.Rentee_sign_panel.Controls.Add(this.Login_lbl);
            this.Rentee_sign_panel.Controls.Add(this.lister_sign_lbl);
            this.Rentee_sign_panel.Controls.Add(this.sign_up_rentee);
            this.Rentee_sign_panel.Location = new System.Drawing.Point(4, 4);
            this.Rentee_sign_panel.Margin = new System.Windows.Forms.Padding(4);
            this.Rentee_sign_panel.Name = "Rentee_sign_panel";
            this.Rentee_sign_panel.Size = new System.Drawing.Size(671, 730);
            this.Rentee_sign_panel.TabIndex = 7;
            // 
            // Login_lbl
            // 
            this.Login_lbl.AutoSize = true;
            this.Login_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_lbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.Login_lbl.Location = new System.Drawing.Point(485, 688);
            this.Login_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Login_lbl.Name = "Login_lbl";
            this.Login_lbl.Size = new System.Drawing.Size(55, 23);
            this.Login_lbl.TabIndex = 3;
            this.Login_lbl.TabStop = true;
            this.Login_lbl.Text = "Login";
            this.Login_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Login_lbl_LinkClicked);
            // 
            // lister_sign_lbl
            // 
            this.lister_sign_lbl.AutoSize = true;
            this.lister_sign_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lister_sign_lbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.lister_sign_lbl.Location = new System.Drawing.Point(286, 685);
            this.lister_sign_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lister_sign_lbl.Name = "lister_sign_lbl";
            this.lister_sign_lbl.Size = new System.Drawing.Size(142, 23);
            this.lister_sign_lbl.TabIndex = 3;
            this.lister_sign_lbl.TabStop = true;
            this.lister_sign_lbl.Text = "Sign up as Lister";
            this.lister_sign_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lister_sign_lbl_LinkClicked);
            // 
            // sign_up_rentee
            // 
            this.sign_up_rentee.AutoSize = true;
            this.sign_up_rentee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_up_rentee.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.sign_up_rentee.Location = new System.Drawing.Point(103, 685);
            this.sign_up_rentee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sign_up_rentee.Name = "sign_up_rentee";
            this.sign_up_rentee.Size = new System.Drawing.Size(149, 23);
            this.sign_up_rentee.TabIndex = 3;
            this.sign_up_rentee.TabStop = true;
            this.sign_up_rentee.Text = "Sign up as rentee";
            this.sign_up_rentee.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sign_up_rentee_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 730);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::prop_finder.Properties.Resources.Vector;
            this.pictureBox2.Location = new System.Drawing.Point(123, 23);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(335, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prop_finder.Properties.Resources.House_searching;
            this.pictureBox1.Location = new System.Drawing.Point(93, 148);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 525);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // us_login_uc1
            // 
            this.us_login_uc1.BackColor = System.Drawing.Color.White;
            this.us_login_uc1.Location = new System.Drawing.Point(0, 0);
            this.us_login_uc1.Margin = new System.Windows.Forms.Padding(5);
            this.us_login_uc1.Name = "us_login_uc1";
            this.us_login_uc1.Size = new System.Drawing.Size(671, 687);
            this.us_login_uc1.TabIndex = 2;
            this.us_login_uc1.Load += new System.EventHandler(this.us_login_uc1_Load);
            // 
            // lister_sign_up_signup1
            // 
            this.lister_sign_up_signup1.BackColor = System.Drawing.Color.White;
            this.lister_sign_up_signup1.Location = new System.Drawing.Point(-4, -4);
            this.lister_sign_up_signup1.Margin = new System.Windows.Forms.Padding(5);
            this.lister_sign_up_signup1.Name = "lister_sign_up_signup1";
            this.lister_sign_up_signup1.Size = new System.Drawing.Size(671, 687);
            this.lister_sign_up_signup1.TabIndex = 0;
            // 
            // rentee_sign_up1
            // 
            this.rentee_sign_up1.BackColor = System.Drawing.Color.White;
            this.rentee_sign_up1.Location = new System.Drawing.Point(0, 0);
            this.rentee_sign_up1.Margin = new System.Windows.Forms.Padding(5);
            this.rentee_sign_up1.Name = "rentee_sign_up1";
            this.rentee_sign_up1.Size = new System.Drawing.Size(671, 665);
            this.rentee_sign_up1.TabIndex = 1;
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(1756, 970);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_form";
            this.Load += new System.EventHandler(this.Login_form_Load);
            this.panel1.ResumeLayout(false);
            this.login_panel.ResumeLayout(false);
            this.Rentee_sign_panel.ResumeLayout(false);
            this.Rentee_sign_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel login_panel;
        private System.Windows.Forms.Panel Rentee_sign_panel;
        private Rentee_sign_up rentee_sign_up1;
        private lister_sign_up_signup lister_sign_up_signup1;
        private System.Windows.Forms.LinkLabel Login_lbl;
        private System.Windows.Forms.LinkLabel lister_sign_lbl;
        private System.Windows.Forms.LinkLabel sign_up_rentee;
        private us_login_uc us_login_uc1;
    }
}