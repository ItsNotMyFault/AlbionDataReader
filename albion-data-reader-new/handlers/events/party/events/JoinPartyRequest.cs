using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albion_data_reader_new.handlers
{
    public class JoinPartyRequest
    {
        public string PartyId { get; set; }
        public string PlayerJoinedId { get; set; }
        public string PlayerJoinedName { get; set; }
    }
}
