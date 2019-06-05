using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace TicketMonitor
{
    class API
    {
        private static string startUrl = "https://helpdesk.msu.montana.edu/helpdesk/WebObjects/Helpdesk.woa";
        WebRequest web = WebRequest.Create(startUrl); //Creates a web request.
        HttpWebResponse response = null; // Sets response in memory
        private string sessionKey;
        internal XmlDocument xml = new XmlDocument();
        internal XmlDocument compareXML = new XmlDocument();
        internal bool isFirstXmlLoaded = false;

        internal Queue<XmlDocument> xmlQueue = new Queue<XmlDocument>();//Creates a stack for our xml documents.

        
        internal API() //Constructor for our API
        {

        }

        internal void getRequest(string url) //method to run a get on the API's url.
        {
            try
            {
                web = WebRequest.Create(url + "&apiKey=" + programPackage.user.getapiKey());
                web.Method = "GET";
                response = (HttpWebResponse)web.GetResponse();

                if(isFirstXmlLoaded == false)
                {
                    xml = gatherData();
                    isFirstXmlLoaded = true;
                }
                else
                {
                    compareXML = gatherData();
                }



                    //programPackage.monitor.updateText(response.write(xml.OuterXml));



            }
            catch (Exception e)
            {
                MessageBox.Show("An error occured requesting your data");
                Console.WriteLine(e);
            }

            //programPackage.monitor.printXML(xml);
        }


        internal void getOpenHelpDeskTickets()
        {
            try
            {
                web = WebRequest.Create(startUrl + "/ra/Tickets.xml?list=group&qualifier=(statustype.listFilterType%3D1)&apiKey=" + programPackage.user.getapiKey());
                web.Method = "GET";
                response = (HttpWebResponse)web.GetResponse();

                if (isFirstXmlLoaded == false)
                {
                    xml = gatherData();
                    isFirstXmlLoaded = true;
                }
                else
                {
                    compareXML = gatherData();
                }



                //programPackage.monitor.updateText(response.write(xml.OuterXml));



            }
            catch (Exception e)
            {
                MessageBox.Show("An error occured requesting your data");
                Console.WriteLine(e);
                Application.Exit();
            }

            //Console.WriteLine(xml.OuterXml);
            //programPackage.monitor.updateText("Just before enqueue");
            //xmlQueue.Enqueue(xml);
            //programPackage.monitor.updateText("After enqueue");
        }


        internal void postRequest(string url, string postData) //Unused currently.
        {

        }
        internal void postCredentialsandGetSessionKey() // This method posts credientials and grabs a session key.
        {
            try
            {
                web = WebRequest.Create("http://helpdesk.msu.montana.edu/helpdesk/WebObjects/Helpdesk.woa/ra/Session.xml?apiKey=" + programPackage.user.getapiKey()); //Grabs xml with session key
                web.Method = "GET";

                response = (HttpWebResponse)web.GetResponse(); // Stores the response from the web request into response.

                if (isFirstXmlLoaded == false)
                {
                    xml = gatherData();
                    isFirstXmlLoaded = true;
                }
                else
                {
                    compareXML = gatherData();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Incorrect Credientials.");
                Console.WriteLine(e);
            }


            try
            {
                var nodes = xml.SelectNodes("Session/sessionKey");
                foreach (XmlElement node in nodes)
                {
                    sessionKey = node.InnerText;
                }

                programPackage.monitor.updateText("Your session key is: " + sessionKey);
            }
            catch (Exception e)
            {
                MessageBox.Show("An error has occured aquiring your session key.");
                Console.WriteLine(e);
            }
        }

        private XmlDocument gatherData() //This function opens a stream with the class' web and response types. Makes into XML and pushes to queue.
        {
            XmlDocument localXML = new XmlDocument();
            using (Stream stream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream);
                string results = reader.ReadToEnd();
                localXML.LoadXml(results);
                reader.Close();


            }
            return localXML;
        }

    }
}
