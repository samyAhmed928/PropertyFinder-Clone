
namespace prop_finder
{
    partial class property_us
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.prop_title_label = new System.Windows.Forms.Label();
            this.Desc_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 160);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prop_finder.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // prop_title_label
            // 
            this.prop_title_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prop_title_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prop_title_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.prop_title_label.Location = new System.Drawing.Point(212, 30);
            this.prop_title_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prop_title_label.Name = "prop_title_label";
            this.prop_title_label.Size = new System.Drawing.Size(700, 28);
            this.prop_title_label.TabIndex = 6;
            this.prop_title_label.Text = "Prop Title";
            this.prop_title_label.Click += new System.EventHandler(this.prop_title_label_Click);
            // 
            // Desc_lbl
            // 
            this.Desc_lbl.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desc_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Desc_lbl.Location = new System.Drawing.Point(215, 86);
            this.Desc_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Desc_lbl.Name = "Desc_lbl";
            this.Desc_lbl.Size = new System.Drawing.Size(517, 65);
            this.Desc_lbl.TabIndex = 6;
            this.Desc_lbl.Text = "Description";
            this.Desc_lbl.Click += new System.EventHandler(this.Desc_lbl_Click);
            // 
            // property_us
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.Controls.Add(this.Desc_lbl);
            this.Controls.Add(this.prop_title_label);
            this.Controls.Add(this.panel1);
            this.Name = "property_us";
            this.Size = new System.Drawing.Size(983, 160);
            this.Load += new System.EventHandler(this.property_us_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label prop_title_label;
        private System.Windows.Forms.Label Desc_lbl;
    }
}
