using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            checkUserFirstLogin();
            //Will store credentials in the user class.
            //user.setUsername(userNameField.Text);
            //user.setapiKey(apiKeyField.Text);
            monitor.Show();
            this.Hide();
            monitor.updateText("Using " + user.getUsername() + " as the username.");

        }

        private void checkUserFirstLogin()
        {
            List<string> userList = getUserList();
            List<string> apiKeyList = getApiKeyList();
            if (userList.Contains(Environment.UserName))
            {
                Console.WriteLine("Returning user");
                user.setUsername(Environment.UserName);

                for(int i = 0; i<userList.Count; i++)
                {
                    if(userList[i] == Environment.UserName)
                    {
                        user.setapiKey(apiKeyList[i]);
                    }
                }

            }
            else
            {
                //New user process goes here.
                newUser newUserWindow = new newUser(); //Creates the window.
                newUserWindow.ShowDialog();


            }
        }

        private List<String> getUserList()
        {
            
            List<String> userList = new List<String>();
            try
            {
                var lines = File.ReadLines("users.txt");
                foreach (var line in lines)
                {
                    userList.Add(line); //Adds each user.
                }


            }
            catch(Exception)
            {
                Console.WriteLine("First time user.");
            }

            return userList;
        }

        private List<String> getApiKeyList()
        {

            List<String> apiKeyList = new List<String>();
            try
            {
                var lines = File.ReadLines("apiKeys.txt");
                foreach (var line in lines)
                {
                    apiKeyList.Add(line); //Adds each user.
                }
                using (System.IO.StreamReader file = new System.IO.StreamReader("apiKeys.txt"))
                {
                    while (!file.EndOfStream)
                    {
                        apiKeyList.Add(file.ReadLine());
                    }
                }


            }
            catch (Exception)
            {
               // Console.WriteLine("File Not Found. Something went wrong.");
               // MessageBox.Show("A critical error has occured. ");
            }

            return apiKeyList;
        }

    }
}
