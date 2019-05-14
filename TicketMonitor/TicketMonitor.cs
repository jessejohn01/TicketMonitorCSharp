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
    internal partial class ticketMonitorFrame : Form
    {

        private string url = "https://helpdesk.msu.montana.edu/helpdesk/WebObjects/Helpdesk.woa";
        

        internal ticketMonitorFrame()
        {
            InitializeComponent();
            
        }

        void ticketMonitorFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TicketMonitorFrame_Load(object sender, EventArgs e)
        {
            API api = new API(); //Creates class that manages the API.
            api.postCredentialsandGetSessionKey();
        }

        internal void updateText(string inString)
        {
            monitorOutputTextBox.Text += inString + Environment.NewLine;
        }
        
    }
}
