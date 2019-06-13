using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TicketMonitor
{
    class refresh
    {

        internal static BackgroundWorker worker = new BackgroundWorker();
        private int progressBarTotal = 0;
        internal refresh()
        {
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            
        }

        internal void start()
        {
            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            if (!worker.IsBusy)
            {
                worker.RunWorkerAsync();
            }
        }
           
        private void worker_DoWork(object sender, DoWorkEventArgs e) //This worker loads in the tickets.
        {
            int seconds;
            programPackage.monitor.apiSession.getOpenHelpDeskTickets();
            switch (programPackage.monitor.optionSettings.refreshTimeOption)
            {
                case "One Minute":
                    seconds = 60;
                    break;
                case "Five Minutes":
                    seconds = 300;
                    break;
                case "Ten Minutes":
                    seconds = 600;
                    break;
                default:
                    seconds = 300;
                    break;
            }

            programPackage.monitor.setProgressBarMax(seconds);

            if (programPackage.monitor.apiSession.compareXML.ChildNodes.Count != 0)//Comaring the xml after a refresh.
            {
                compare(programPackage.monitor.apiSession.xml, programPackage.monitor.apiSession.compareXML); //Compare old to new
            }

            for (int i = 0; i < programPackage.monitor.progressBarMax(); i++) //Wait for 5 minutes and then refresh.
            {
                Thread.Sleep(1000);
                progressBarTotal++;
                programPackage.monitor.updateProgress(progressBarTotal);

                if (worker.CancellationPending) //Checks to see if we need to kill the thread.
                {
                    break;
                }
            }

            //Do work here.





        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBarTotal = 0;
            programPackage.monitor.updateProgress(progressBarTotal);

           
            if (!worker.IsBusy)
            {
                programPackage.monitor.clearText();
                worker.RunWorkerAsync();
            }
        }

        internal void stop()
        {
            worker.CancelAsync();
            GC.Collect(); //manual garbage collection!
        }

        private void compare(XmlDocument oldXML, XmlDocument newXML)
        {
            programPackage.monitor.clearText();
            bool changeDetected = false;
            /*This next section grabs a list of Tickets from the xml. So it will have a list of all the tickets with all its child tags
             <Ticket id="123456" type="Ticket">
                <lastupdated> Insert date time here    </lastUpdated>
                <otherDetails> This ticket has a lot of tags associated with it   </otherDetails>
                ....
            </Ticket>

            <Ticket id="654321" type="Ticket">
                ...
            </Ticket>


            You have a list of above.
            */
            XmlNodeList oldTickets = oldXML.DocumentElement.SelectNodes("Ticket"); //Selects all the tickets in the initial xml.
            XmlNodeList newTickets = newXML.DocumentElement.SelectNodes("Ticket"); //Selects all tickets in the new refreshed xml.

            if(oldTickets[0].Attributes["id"].Value != newTickets[0].Attributes["id"].Value) //if the last updated ticket does not match something changed.
            {
                changeDetected = true;
            }

            //Tread this section carefully. Step through it to understand. We take a ticket post refresh and compare it to each ticket from the initial run. 
            bool hasMatch = false;
            foreach (XmlNode newTicket in newTickets)
            {
                foreach(XmlNode oldTicket in oldTickets)
                {
                    if (newTicket.Attributes["id"].Value == oldTicket.Attributes["id"].Value)
                    {
                        //Console.WriteLine("New ticket has a match with old ticket: " + newTicket.Attributes["id"].Value);
                        hasMatch = true;
                        //Console.WriteLine("Checking if anything changed within the ticket.");
                        try
                        {
                            //Console.WriteLine("Reached");
                            //Console.WriteLine(newTicket.SelectSingleNode("latestNote").SelectSingleNode("mobileListText").InnerText);
                            string newTicketNote = newTicket.SelectSingleNode("latestNote").SelectSingleNode("mobileListText").InnerText;
                            //Console.WriteLine(oldTicket.SelectSingleNode("latestNote").SelectSingleNode("mobileListText").InnerText);
                            string oldTicketNote = oldTicket.SelectSingleNode("latestNote").SelectSingleNode("mobileListText").InnerText;

                                if (newTicketNote != oldTicketNote)
                                {
                                    programPackage.monitor.updateText("Ticket " + newTicket.Attributes["id"].Value + " has a new note.");
                                    changeDetected = true;
                                }
                                else
                                {
                                   // Console.WriteLine("There is no changes detected in this ticket.");
                                }
                            }catch(Exception e)
                            {
                                Console.WriteLine(e);
                            }

                        
                    }
                }
                if (hasMatch == false)
                {
                    programPackage.monitor.updateText("Ticket " + newTicket.Attributes["id"].Value + " is a new ticket. ");
                }
                hasMatch = false;
            }

            if (changeDetected == true)
            {
                programPackage.monitor.updateText("A change was detected.");
                MessageBox.Show("A change was detected.");
            }
            else
            {
                programPackage.monitor.updateText("No changes to the ticket system were found.");
            }
            programPackage.monitor.apiSession.xml = programPackage.monitor.apiSession.compareXML;

        }


        private string convertXMLtoString(XmlDocument inXML) //Helper function to convert an XmlDocument to a string.
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
            return sb.ToString();
        }


    }

}
