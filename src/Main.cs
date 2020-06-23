using DailyQuotes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyMotivation
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
            InitializeDesktop();  
   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var uc = new MainUserControl();
            DisplayPanel.Controls.Add(uc);
            uc.Show();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //empty implementation
            e.Graphics.FillRectangle(Brushes.LimeGreen, e.ClipRectangle);
        }

        private void DisplayPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InitializeDesktop()
        {
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            this.ShowInTaskbar = false;

        }



    }
}
