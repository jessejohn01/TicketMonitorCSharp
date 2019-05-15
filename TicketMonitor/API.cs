﻿using System;
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
        XmlDocument xml = new XmlDocument();
        
        internal API() //Constructor for our API
        {

        }

        internal void getRequest(string url) //method to run a get on the API's url.
        {
            try
            {
                web = WebRequest.Create(url + ".xml?apiKey=" + programPackage.user.getapiKey());
                web.Method = "GET";
                response = (HttpWebResponse)web.GetResponse();
                gatherData();

            }
            catch (Exception)
            {
                MessageBox.Show("An error occured requesting your data");
            }
        }

        internal void postRequest(string url, string postData)
        {

        }
        internal void postCredentialsandGetSessionKey() // THis method posts credientials and grabs a session key.
        {
            try
            {
                web = WebRequest.Create("http://helpdesk.msu.montana.edu/helpdesk/WebObjects/Helpdesk.woa/ra/Session.xml?apiKey=" + programPackage.user.getapiKey()); //Grabs xml with session key
                web.Method = "GET";

                response = (HttpWebResponse)web.GetResponse(); // Stores the response from the web request into response.

                gatherData();

            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect Credientials.");
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
            catch (Exception)
            {
                MessageBox.Show("An error has occured aquiring your session key.");
            }
        }

        private void gatherData() //This function opens a stream with the class' web and response types.
        {
            using (Stream stream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream);
                string results = reader.ReadToEnd();
                Console.WriteLine(results);
                xml.LoadXml(results);
                reader.Close();


            }
        }

    }
}
