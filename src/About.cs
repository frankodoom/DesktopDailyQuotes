using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyQuotes
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            lb_author.Text = Resources.about.Replace("{year}",DateTime.Now.Year.ToString());
            lb_licence.Text = Resources.licence;
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
