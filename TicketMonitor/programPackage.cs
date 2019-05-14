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
    internal partial class programPackage : Form
    {
        internal static ticketMonitorFrame monitor = new ticketMonitorFrame();
        internal static user user = new user();
        internal programPackage()
        {
            InitializeComponent();

        }

        private void loginButton_Click(object sender, EventArgs e) //If the login button is clicked then do this.
        { 
            //Will store credentials in the user class.
            user.setUsername(userNameField.Text);
            user.setapiKey(apiKeyField.Text);
            monitor.updateText("Using " + user.getUsername() + " as the username.");
            monitor.Show();
            this.Hide();
        }


    }
}
