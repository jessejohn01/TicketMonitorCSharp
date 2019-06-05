using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TicketMonitor
{
    internal partial class ticketMonitorFrame : Form
    {
        
        internal string url = "https://helpdesk.msu.montana.edu/helpdesk/WebObjects/Helpdesk.woa";
        internal API apiSession = new API(); //Creates class that manages the API.
        internal option optionSettings = new option();
        refresh background = new refresh();

        internal ticketMonitorFrame()
        {
            InitializeComponent();
            debugGet.Hide();
            getHelpDeskOpen.Hide();
            
        }

        void ticketMonitorFrame_FormClosed(object sender, FormClosedEventArgs e) //When the main window is closed.
        {
            Application.Exit();
        }

        private void TicketMonitorFrame_Load(object sender, EventArgs e)//Upon loading the main window.
        {

            //apiSession.postCredentialsandGetSessionKey();
            if(programPackage.user.getUsername() == "yaBoi") //Secret debugging user.
            {
                debugGet.Show();
                getHelpDeskOpen.Show();
            }
            background.start();


        }

        internal void updateText(string inString) //updates the text in the text box in the main window. 
        {
            try
            {
                Invoke(new Action(() =>
                {
                    monitorOutputTextBox.Text += inString + Environment.NewLine;
                }));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


        internal void updateProgress(int newTotal)//updates the progress value of the progress bar.
        {
            try
            {
                Invoke(new Action(() =>
                {
                    progressBar.Value = newTotal;
                    progressBar.Update();
                }));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        internal int progressBarMax()//returns the max amount of the progress bar.
        {
            return progressBar.Maximum;
        }

        internal void setProgressBarMax(int inSeconds)//Sets the maximum value for the progress bar
        {

            try
            {
                Invoke(new Action(() =>
                {
                    progressBar.Maximum = inSeconds;
                    progressBar.Update();
                }));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }


        private void updateOptions()//Updates the class optionSettings with the selected items in the option menu.
        {
            optionSettings.refreshTimeOption = refreshTime.SelectedItem.ToString();
        }


        // TO DO RENAME ALL THIS.
        private void OptionsToolStripMenuItem_Click_1(object sender, EventArgs e)//If you click the option button up top.
        {
            refreshTime.SelectedItem = optionSettings.refreshTimeOption;
            pages.SelectedTab = tabPage2;
        }

        private void OptionSaveButton_Click_1(object sender, EventArgs e)//Click the option menu's save button.
        {
            updateOptions();
            pages.SelectedTab = tabPage1;
            background.stop();
            background = new refresh();
            background.start();
            updateProgress(0);
        }

        private void ManualRefreshToolStripMenuItem_Click_1(object sender, EventArgs e)//Click the manual refresh button up top.
        {
            background.stop();
            background = new refresh();
            background.start();
            updateText("Manual Refresh Initiated.");
        }

        private void DebugGet_Click_1(object sender, EventArgs e)// Click debugging button. Needs debugging username to see.
        {
            //clearText();
            apiSession.getOpenHelpDeskTickets();          

        }


        private void GetHelpDeskOpen_Click(object sender, EventArgs e) // Click other debugging button. Needs username to see
        {
            clearText();
            //apiSession.getRequest(url + "/ra/Tickets.xml?list=group&qualifier=(statustype.listFilterType%3D1)"); //API class will add a trailing &apiKey=****
        }

        internal void printXML(XmlDocument inXML)//class to format and print an xml document to monitorOutputTextBox.
        {
            StringBuilder sb = new StringBuilder();
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "  ",
                NewLineChars = "\r\n",
                NewLineHandling = NewLineHandling.Replace
            };
            using (XmlWriter writer = XmlWriter.Create(sb, settings))
            {
                inXML.Save(writer);
            }
            updateText(sb.ToString());
        }

        internal void clearText()
        {
            try
            {
                Invoke(new Action(() =>
                {
                    monitorOutputTextBox.Clear();
                }));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
