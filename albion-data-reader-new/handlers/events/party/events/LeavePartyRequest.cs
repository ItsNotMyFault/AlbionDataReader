using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albion_data_reader_new.handlers
{
    public class LeavePartyRequest
    {
        public string PartyId { get; set; }
        public string PlayerLeftId { get; set; }
        public bool IsPartyClosed{ get; set; }
    }
}
