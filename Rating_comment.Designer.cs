
namespace prop_finder
{
    partial class Rating_comment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Comment_txt = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.star1_bx = new System.Windows.Forms.PictureBox();
            this.email_label = new System.Windows.Forms.LinkLabel();
            this.us_label = new System.Windows.Forms.Label();
            this.disLike_bx = new System.Windows.Forms.PictureBox();
            this.Like_bx = new System.Windows.Forms.PictureBox();
            this.prof_pic = new prop_finder.CircularPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic_star3 = new System.Windows.Forms.PictureBox();
            this.pic_star4 = new System.Windows.Forms.PictureBox();
            this.pic_star5 = new System.Windows.Forms.PictureBox();
            this.picture_star2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.star1_bx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disLike_bx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Like_bx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prof_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_star3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_star4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_star5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_star2)).BeginInit();
            this.SuspendLayout();
            // 
            // Comment_txt
            // 
            this.Comment_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Comment_txt.Enabled = false;
            this.Comment_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comment_txt.Location = new System.Drawing.Point(83, 66);
            this.Comment_txt.Name = "Comment_txt";
            this.Comment_txt.Size = new System.Drawing.Size(446, 63);
            this.Comment_txt.TabIndex = 11;
            this.Comment_txt.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce sit amet tortor ac" +
    " odio dignissim \nmalesuada vitae quis sapien. Integer suscipit metus vel eros co" +
    "ngue, id congue orci posuere.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picture_star2);
            this.panel1.Controls.Add(this.pic_star5);
            this.panel1.Controls.Add(this.pic_star4);
            this.panel1.Controls.Add(this.pic_star3);
            this.panel1.Controls.Add(this.star1_bx);
            this.panel1.Location = new System.Drawing.Point(416, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 28);
            this.panel1.TabIndex = 10;
            // 
            // star1_bx
            // 
            this.star1_bx.Image = global::prop_finder.Properties.Resources.star;
            this.star1_bx.Location = new System.Drawing.Point(0, 2);
            this.star1_bx.Name = "star1_bx";
            this.star1_bx.Size = new System.Drawing.Size(31, 26);
            this.star1_bx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star1_bx.TabIndex = 6;
            this.star1_bx.TabStop = false;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.email_label.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.email_label.Location = new System.Drawing.Point(80, 41);
            this.email_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(182, 17);
            this.email_label.TabIndex = 9;
            this.email_label.TabStop = true;
            this.email_label.Text = "User_name123@gmail.com";
            // 
            // us_label
            // 
            this.us_label.AutoSize = true;
            this.us_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.us_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.us_label.Location = new System.Drawing.Point(75, 10);
            this.us_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.us_label.Name = "us_label";
            this.us_label.Size = new System.Drawing.Size(116, 28);
            this.us_label.TabIndex = 8;
            this.us_label.Text = "User Name";
            // 
            // disLike_bx
            // 
            this.disLike_bx.Image = global::prop_finder.Properties.Resources.dislike;
            this.disLike_bx.Location = new System.Drawing.Point(510, 133);
            this.disLike_bx.Name = "disLike_bx";
            this.disLike_bx.Size = new System.Drawing.Size(31, 34);
            this.disLike_bx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.disLike_bx.TabIndex = 12;
            this.disLike_bx.TabStop = false;
            this.disLike_bx.Click += new System.EventHandler(this.disLike_bx_Click);
            // 
            // Like_bx
            // 
            this.Like_bx.Image = global::prop_finder.Properties.Resources.like;
            this.Like_bx.Location = new System.Drawing.Point(559, 127);
            this.Like_bx.Name = "Like_bx";
            this.Like_bx.Size = new System.Drawing.Size(31, 34);
            this.Like_bx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Like_bx.TabIndex = 13;
            this.Like_bx.TabStop = false;
            this.Like_bx.Click += new System.EventHandler(this.Like_bx_Click);
            // 
            // prof_pic
            // 
            this.prof_pic.Border = 2;
            this.prof_pic.BorderCap = System.Drawing.Drawing2D.DashCap.Flat;
            this.prof_pic.Borderstyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.prof_pic.ColorBorder = System.Drawing.Color.RoyalBlue;
            this.prof_pic.ColorBorder2 = System.Drawing.Color.HotPink;
            this.prof_pic.Gradiant = 50F;
            this.prof_pic.Image = global::prop_finder.Properties.Resources.man;
            this.prof_pic.Location = new System.Drawing.Point(7, 3);
            this.prof_pic.Name = "prof_pic";
            this.prof_pic.Size = new System.Drawing.Size(62, 62);
            this.prof_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prof_pic.TabIndex = 7;
            this.prof_pic.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(0, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 18);
            this.panel2.TabIndex = 14;
            // 
            // pic_star3
            // 
            this.pic_star3.Image = global::prop_finder.Properties.Resources.star;
            this.pic_star3.Location = new System.Drawing.Point(74, 0);
            this.pic_star3.Name = "pic_star3";
            this.pic_star3.Size = new System.Drawing.Size(31, 26);
            this.pic_star3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_star3.TabIndex = 6;
            this.pic_star3.TabStop = false;
            // 
            // pic_star4
            // 
            this.pic_star4.Image = global::prop_finder.Properties.Resources.star;
            this.pic_star4.Location = new System.Drawing.Point(111, 0);
            this.pic_star4.Name = "pic_star4";
            this.pic_star4.Size = new System.Drawing.Size(31, 26);
            this.pic_star4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_star4.TabIndex = 6;
            this.pic_star4.TabStop = false;
            // 
            // pic_star5
            // 
            this.pic_star5.Image = global::prop_finder.Properties.Resources.star;
            this.pic_star5.Location = new System.Drawing.Point(152, -1);
            this.pic_star5.Name = "pic_star5";
            this.pic_star5.Size = new System.Drawing.Size(31, 26);
            this.pic_star5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_star5.TabIndex = 6;
            this.pic_star5.TabStop = false;
            // 
            // picture_star2
            // 
            this.picture_star2.Image = global::prop_finder.Properties.Resources.star;
            this.picture_star2.Location = new System.Drawing.Point(37, 0);
            this.picture_star2.Name = "picture_star2";
            this.picture_star2.Size = new System.Drawing.Size(31, 26);
            this.picture_star2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_star2.TabIndex = 15;
            this.picture_star2.TabStop = false;
            // 
            // Rating_comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Comment_txt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.us_label);
            this.Controls.Add(this.disLike_bx);
            this.Controls.Add(this.Like_bx);
            this.Controls.Add(this.prof_pic);
            this.Name = "Rating_comment";
            this.Size = new System.Drawing.Size(609, 182);
            this.Load += new System.EventHandler(this.Rating_comment_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.star1_bx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disLike_bx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Like_bx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prof_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_star3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_star4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_star5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_star2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Comment_txt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox star1_bx;
        private System.Windows.Forms.LinkLabel email_label;
        private System.Windows.Forms.Label us_label;
        private System.Windows.Forms.PictureBox disLike_bx;
        private System.Windows.Forms.PictureBox Like_bx;
        private CircularPictureBox prof_pic;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic_star5;
        private System.Windows.Forms.PictureBox pic_star4;
        private System.Windows.Forms.PictureBox pic_star3;
        private System.Windows.Forms.PictureBox picture_star2;
    }
}
