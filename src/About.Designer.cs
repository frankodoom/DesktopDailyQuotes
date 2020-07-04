namespace DailyQuotes
{
    partial class About
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
            this.lb_author = new System.Windows.Forms.Label();
            this.lb_licence = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DailyQuotes.Resources.sample_logo1;
            this.pictureBox1.Location = new System.Drawing.Point(317, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_author
            // 
            this.lb_author.AutoSize = true;
            this.lb_author.Location = new System.Drawing.Point(208, 261);
            this.lb_author.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_author.Name = "lb_author";
            this.lb_author.Size = new System.Drawing.Size(109, 37);
            this.lb_author.TabIndex = 1;
            this.lb_author.Text = "author";
            // 
            // lb_licence
            // 
            this.lb_licence.AutoSize = true;
            this.lb_licence.Location = new System.Drawing.Point(310, 321);
            this.lb_licence.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_licence.Name = "lb_licence";
            this.lb_licence.Size = new System.Drawing.Size(115, 37);
            this.lb_licence.TabIndex = 2;
            this.lb_licence.Text = "licence";
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(312, 394);
            this.btn_Ok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(211, 91);
            this.btn_Ok.TabIndex = 3;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 531);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.lb_licence);
            this.Controls.Add(this.lb_author);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "About";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_author;
        private System.Windows.Forms.Label lb_licence;
        private System.Windows.Forms.Button btn_Ok;
    }
}