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
        //push
        private string url = "https://helpdesk.msu.montana.edu/helpdesk/WebObjects/Helpdesk.woa";
        API apiSession = new API(); //Creates class that manages the API.

        internal ticketMonitorFrame()
        {
            InitializeComponent();
            debugGet.Hide();
            
        }

        void ticketMonitorFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TicketMonitorFrame_Load(object sender, EventArgs e)
        {

            apiSession.postCredentialsandGetSessionKey();
            if(programPackage.user.getUsername() == "yaBoi") //Secret debugging user.
            {
                debugGet.Show();
            }
        }

        internal void updateText(string inString)
        {
            monitorOutputTextBox.Text += inString + Environment.NewLine;
        }

        private void DebugGet_Click(object sender, EventArgs e)
        {
            apiSession.getRequest(url + "/ra/Tickets/1");
        }
    }
}
