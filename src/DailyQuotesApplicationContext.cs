using DailyMotivation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyQuotes
{
   public  class DailyQuotesApplicationContext: ApplicationContext
    {
        private NotifyIcon trayIcon;
        public DailyQuotesApplicationContext()
        {
            // Initialize Tray Icon
            trayIcon = new NotifyIcon()
            {
                Icon = Resources.sample_logo,
                Text ="Daily Quotes",
                ContextMenu = new ContextMenu(new MenuItem[] {
                new MenuItem("About", About),
                new MenuItem("Exit", Exit),
          
            }),
                Visible = true
            };

            //Start Quotes Window
            var main = new Main();
            main.Show();
        }

        private void About(object sender, EventArgs e)
        {   
             //open the about dialogbox
             var about = new About();
             about.ShowDialog();
        }

        void Exit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            trayIcon.Visible = false;
            Application.Exit();
        }
    }
}
