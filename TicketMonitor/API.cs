using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.IO;
using System.Windows.Forms;

namespace TicketMonitor
{
    class API
    {
        private static string startUrl = "https://helpdesk.msu.montana.edu/helpdesk/WebObjects/Helpdesk.woa"; //
        WebRequest web = WebRequest.Create(startUrl); //Creates a web request.
        HttpWebResponse response = null; // Sets response in memory
        internal API() //Constructor for our API
        {
           /* WebRequest web = WebRequest.Create(url); //Creates a web request.
            web.Method = "GET"; //This particular request is a GET
            HttpWebResponse response = null; // Sets response in memory
            response = (HttpWebResponse) web.GetResponse(); // Stores the response from the web request into response.

            using (Stream stream = response.GetResponseStream()) // Creates a stream of from the response of the request
            {
                StreamReader reader = new StreamReader(stream); //Reader then reads the stream 
                string results = reader.ReadToEnd(); // Outputs to a string

                programPackage.monitor.updateText("This is a message.");
                programPackage.monitor.updateText("This is also a message");
                programPackage.monitor.updateText(results);
                reader.Close(); // Close our stream reader.



            } */

        }

        internal void getRequest(string url) //method to run a get on the API's url.
        {
            web = WebRequest.Create(url);
            web.Method = "GET"; //This particular request is a GET
            
            response = (HttpWebResponse)web.GetResponse(); // Stores the response from the web request into response.

            using (Stream stream = response.GetResponseStream()) // Creates a stream of from the response of the request
            {
                StreamReader reader = new StreamReader(stream); //Reader then reads the stream 
                string results = reader.ReadToEnd(); // Outputs to a string
                //programPackage.monitor.updateText(results);
                reader.Close(); // Close our stream reader.



            }
        }

        internal void postRequest(string url, string postData)
        {

        }
        internal void postCredentialsandGetSessionKey()
        {

            try
            {
                web = WebRequest.Create("http://helpdesk.msu.montana.edu/helpdesk/WebObjects/Helpdesk.woa/ra/Ticket/1?apiKey=" + programPackage.user.getapiKey());
                web.Method = "GET";

                response = (HttpWebResponse)web.GetResponse(); // Stores the response from the web request into response.

                using (Stream stream = response.GetResponseStream()) // Creates a stream of from the response of the request
                {
                    StreamReader reader = new StreamReader(stream); //Reader then reads the stream 
                    string results = reader.ReadToEnd(); // Outputs to a string
                    programPackage.monitor.updateText(results);
                    reader.Close(); // Close our stream reader.


                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Incorrect Credientials.");
            }

        }

    }
}
