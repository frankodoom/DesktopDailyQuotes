using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyMotivation
{
    public partial class MainUserControl : UserControl
    {
        public MainUserControl()
        {
            InitializeComponent();
            
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            lb_quote.Text = "This is a sample quote by Nobody";
        }

		// Keep track of when fake "drag and drop" mode is enabled.
		private bool isDragging = false;

		// Store the location where the user clicked the control.
		private int clickOffsetX, clickOffsetY;

		// Start dragging.
		private void lb_quote_Dragger_MouseDown(System.Object sender,
			System.Windows.Forms.MouseEventArgs e)
		{
			isDragging = true;
			clickOffsetX = e.X;
			clickOffsetY = e.Y;
		}

		// End dragging.
		private void lb_quote_MouseUp(System.Object sender,
			System.Windows.Forms.MouseEventArgs e)
		{
			isDragging = false;
		}


		// Move the control (during dragging).
		private void lb_quote_MouseMove(System.Object sender,
			System.Windows.Forms.MouseEventArgs e)
		{
			if (isDragging == true)
			{
				// The control coordinates are converted into form coordinates
				// by adding the label position offset.
				// The offset where the user clicked in the control is also
				// accounted for. Otherwise, it looks like the top-left corner
				// of the label is attached to the mouse.
				lb_quote.Left = e.X + lb_quote.Left - clickOffsetX;
				lb_quote.Top = e.Y + lb_quote.Top - clickOffsetY;
			}
		}
	}
}
