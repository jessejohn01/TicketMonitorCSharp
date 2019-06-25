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
    public partial class newUser : Form
    {
        public newUser()//Constructor for the new user class
        {
            InitializeComponent();
        }

        private void newUser_FormClosing(object sender, EventArgs e) //If the user closes the form close the entire application.
        {
            Application.Exit();
        }
        
        private void SaveButton_Click(object sender, EventArgs e) //Happens after the save button is clicked. Will authenticate API key and save it.
        {
            programPackage.user.setUsername(Environment.UserName);
            programPackage.user.setapiKey(apiKeyTextBox.Text);

            try
            {
                bool loginSuccessful = false;
                loginSuccessful = programPackage.monitor.apiSession.getRequest(programPackage.monitor.url + "/ra/Tickets.xml?list=group&limit=100&qualifier=(statustype.listFilterType%3D1)");
                if(loginSuccessful == false)
                {
                    return;
                }
            }catch(Exception)
            {
                MessageBox.Show("That API key is incorrect. Please try again");
                return; // Will return and not save the key
            }
            int index = 0;
            List<String> userList = getUserList();
            for(int i = 0; i<userList.Count; i++)
            {
                if(userList[i] == Environment.UserName)
                {
                    index = i;
                }
            }

            try
            {
                List<string> apiKeyList = new List<string>();

                var lines = File.ReadLines("apiKeys.txt");
                apiKeyList = getApiKeyList();    

                apiKeyList.Insert(index, apiKeyTextBox.Text);//Write user's apikey.
                using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter("apiKeys.txt")) //rewrites entire file.
                {
                    for(int i = 0; i<apiKeyList.Count; i++)
                    {
                        writeFile.WriteLine(apiKeyList.ElementAt(i));
                    }

                }
            }
            catch(FileNotFoundException) //If no file is found make one.
            {
                
                using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter("apiKeys.txt"))
                {
                    writeFile.WriteLine(apiKeyTextBox.Text); //Write the first key.
                }
            }


            this.Hide();
            programPackage.monitor.Show();

        }

        private void CancelButton_Click(object sender, EventArgs e) //Cancels the new user window.
        {
            this.Hide();
        }

        private List<String> getUserList()//function to get the user list. 
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
            catch (Exception)
            {
                Console.WriteLine("First time run generating user file. ");
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("users.txt"))
                {
                    file.WriteLine(Environment.UserName); //Initialize the file. 
                }
            }

            return userList;
        }

        private List<String> getApiKeyList()// function to get the apikey list from a file. 
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
                    while (!file.EndOfStream) {
                        apiKeyList.Add(file.ReadLine());
                    }
                }


            }
            catch (Exception)
            {
                Console.WriteLine("First time run generating user file. ");
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("apiKeys.txt"))
                {
                    file.WriteLine(""); //Initialize the file. 
                }
            }

            return apiKeyList;
        }
    }
}
