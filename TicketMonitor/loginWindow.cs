using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketMonitor
{
    public partial class loginFrame : Form
    {
        public loginFrame()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e) //If the login button is clicked than do this.
        {
              
            ticketMonitorFrame ticketMonitorFrame = new ticketMonitorFrame();
            ticketMonitorFrame.Show();
        }


    }
}
