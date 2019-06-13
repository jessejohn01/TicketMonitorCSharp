using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMonitor
{
    class option
    {
        internal string refreshTimeOption { get; set; } //Which option is selected fro refresh time.
        internal int refreshTimeSeconds { get; set; }       
        internal option()
        {
            refreshTimeOption = "Five Minutes";
        }



    }
}
