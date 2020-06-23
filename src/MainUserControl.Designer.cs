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
            this.SuspendLayout();
            // 
            // lb_quote
            // 
            this.lb_quote.AutoSize = true;
            this.lb_quote.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quote.Location = new System.Drawing.Point(1899, 295);
            this.lb_quote.Name = "lb_quote";
            this.lb_quote.Size = new System.Drawing.Size(205, 91);
            this.lb_quote.TabIndex = 0;
            this.lb_quote.Text = "label";
            this.lb_quote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_quote.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_quote_Dragger_MouseDown);
            this.lb_quote.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lb_quote_MouseMove);
            this.lb_quote.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lb_quote_MouseUp);
            // 
            // MainUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lb_quote);
            this.Name = "MainUserControl";
            this.Size = new System.Drawing.Size(4843, 3073);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_quote;
    }
}
