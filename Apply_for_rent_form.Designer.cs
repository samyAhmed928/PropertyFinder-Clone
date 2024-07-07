
namespace prop_finder
{
    partial class Apply_for_rent_form
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
            this.us_label = new System.Windows.Forms.Label();
            this.sug_price_nud = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.message_txt = new System.Windows.Forms.RichTextBox();
            this.apply_for_rent_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sug_price_nud)).BeginInit();
            this.SuspendLayout();
            // 
            // us_label
            // 
            this.us_label.AutoSize = true;
            this.us_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.us_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.us_label.Location = new System.Drawing.Point(9, 29);
            this.us_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.us_label.Name = "us_label";
            this.us_label.Size = new System.Drawing.Size(180, 28);
            this.us_label.TabIndex = 2;
            this.us_label.Text = "Suggested Price : ";
            // 
            // sug_price_nud
            // 
            this.sug_price_nud.BackColor = System.Drawing.Color.White;
            this.sug_price_nud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sug_price_nud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sug_price_nud.Location = new System.Drawing.Point(235, 37);
            this.sug_price_nud.Name = "sug_price_nud";
            this.sug_price_nud.Size = new System.Drawing.Size(175, 24);
            this.sug_price_nud.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(9, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Message for Lister : ";
            // 
            // message_txt
            // 
            this.message_txt.Location = new System.Drawing.Point(14, 147);
            this.message_txt.Name = "message_txt";
            this.message_txt.Size = new System.Drawing.Size(460, 82);
            this.message_txt.TabIndex = 4;
            this.message_txt.Text = "";
            // 
            // apply_for_rent_btn
            // 
            this.apply_for_rent_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(94)))), ((int)(((byte)(78)))));
            this.apply_for_rent_btn.FlatAppearance.BorderSize = 0;
            this.apply_for_rent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apply_for_rent_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apply_for_rent_btn.ForeColor = System.Drawing.Color.White;
            this.apply_for_rent_btn.Location = new System.Drawing.Point(127, 236);
            this.apply_for_rent_btn.Margin = new System.Windows.Forms.Padding(4);
            this.apply_for_rent_btn.Name = "apply_for_rent_btn";
            this.apply_for_rent_btn.Size = new System.Drawing.Size(250, 48);
            this.apply_for_rent_btn.TabIndex = 5;
            this.apply_for_rent_btn.Text = "Apply for Rent";
            this.apply_for_rent_btn.UseVisualStyleBackColor = false;
            this.apply_for_rent_btn.Click += new System.EventHandler(this.apply_for_rent_btn_Click);
            // 
            // Apply_for_rent_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(505, 297);
            this.Controls.Add(this.apply_for_rent_btn);
            this.Controls.Add(this.message_txt);
            this.Controls.Add(this.sug_price_nud);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.us_label);
            this.Name = "Apply_for_rent_form";
            this.Text = "Apply_for_rent_form";
            this.Load += new System.EventHandler(this.Apply_for_rent_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sug_price_nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label us_label;
        private System.Windows.Forms.NumericUpDown sug_price_nud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox message_txt;
        private System.Windows.Forms.Button apply_for_rent_btn;
    }
}