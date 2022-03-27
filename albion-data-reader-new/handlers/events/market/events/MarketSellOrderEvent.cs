using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albion_data_reader_new.handlers.market.events
{
    public class MarketSellOrderEvent
    {
        public string PartyStartTime { get; set; }
        public Guid PartyId { get; set; }
        public string Player1Id { get; set; }
        public string Player1Name { get; set; }
        public string Player2Id { get; set; }
        public string Player2Name { get; set; }
    }
}
