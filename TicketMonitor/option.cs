using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMonitor
{
    class option
    {
        internal string refreshTimeOption { get; set; }
        internal int refreshTimeSeconds { get; set; }        
        internal option()
        {
            refreshTimeOption = "Five Minutes";
        }



    }
}
