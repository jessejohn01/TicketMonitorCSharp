using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMonitor
{
    class user
    {
        private string username;
        private string apiKey;
        internal user()
        {

        }

        internal string getUsername()
        {
            return username;
        }

        internal void setUsername(string inUser)
        {
            username = inUser;  
        }

        internal string getapiKey()
        {
            return apiKey;
        }

        internal void setapiKey(string inPass)
        {
            apiKey = inPass;
        }
    }
}
