namespace DailyMotivation
{
    partial class MainUserControl
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
            this.lb_quote = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_quote
            // 
            this.lb_quote.AutoSize = true;
            this.lb_quote.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quote.Location = new System.Drawing.Point(2437, 441);
            this.lb_quote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_quote.Name = "lb_quote";
            this.lb_quote.Size = new System.Drawing.Size(284, 108);
            this.lb_quote.TabIndex = 0;
            this.lb_quote.Text = "quote";
            this.lb_quote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_quote.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_quote_Dragger_MouseDown);
            this.lb_quote.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lb_quote_MouseMove);
            this.lb_quote.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lb_quote_MouseUp);
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor.Location = new System.Drawing.Point(2511, 582);
            this.lbAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(374, 108);
            this.lbAuthor.TabIndex = 2;
            this.lbAuthor.Text = "- author";
            this.lbAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.lb_quote);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainUserControl";
            this.Size = new System.Drawing.Size(5751, 3668);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_quote;
        public System.Windows.Forms.Label lbAuthor;
    }
}
