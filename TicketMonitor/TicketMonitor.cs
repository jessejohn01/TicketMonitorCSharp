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
        API apiSession = new API(); //Creates class that manages the API.
        internal option optionSettings = new option();
        refresh background = new refresh();

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
            background.start();


        }

        internal void updateText(string inString)
        {
            monitorOutputTextBox.Text += inString + Environment.NewLine;
        }

        private void DebugGet_Click(object sender, EventArgs e)
        {
            apiSession.getRequest(url + "/ra/Tickets/1");
        }

        internal void updateProgress(int newTotal)
        {
            try
            {
                Invoke(new Action(() =>
                {
                    progressBar.Value = newTotal;
                    Console.WriteLine(newTotal);
                    progressBar.Update();
                }));
            }
            catch (Exception)
            {

            }
        }

        internal int progressBarMax()
        {
            return progressBar.Maximum;
        }

        internal void setProgressBarMax(int inSeconds)
        {

            try
            {
                Invoke(new Action(() =>
                {
                    progressBar.Maximum = inSeconds;
                    progressBar.Update();
                }));
            }
            catch (Exception)
            {

            }

        }

        private void OptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //=======================SETUP==============================
            optionPanel.BringToFront();
            optionPanel.Show();
            refreshTime.SelectedItem = optionSettings.refreshTimeOption;
            ///
        }

        private void OptionSaveButton_Click(object sender, EventArgs e)
        {
            updateOptions();
            optionPanel.Hide();
            background.stop();
            background = new refresh();
            background.start();
            
        }

        private void updateOptions()
        {
            optionSettings.refreshTimeOption = refreshTime.SelectedItem.ToString();
        }

        private void ManualRefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            background.stop();
            background = new refresh();
            background.start();
            updateText("Manual Refresh Initiated.");
        }
    }
}
