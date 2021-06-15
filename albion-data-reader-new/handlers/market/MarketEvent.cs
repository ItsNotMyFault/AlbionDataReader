using Albion.Network;
using albion_data_reader_new.handlers.market.events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albion_data_reader_new.handlers.market
{
    public class MarketEvent : BaseEvent
    {
        public MarketSellOrderEvent marketSellOrderEvent;
        public MarketEvent(Dictionary<byte, object> parameters) : base(parameters)
        {
            try
            {
                EventCodes eventCode = Common.ParseEventCode(parameters);
                if (eventCode == EventCodes.evNewSimpleItem)
                {
                    var test = 0;
                }

                if (eventCode == EventCodes.evLeftChatChannel)
                {
                    var test = 0;
                }
                if (eventCode == EventCodes.evAccessStatus)
                {
                    var test = 0;
                }
                if (eventCode == EventCodes.evTrashItem)
                {
                    var test = 0;
                }
                if (eventCode == EventCodes.evPlayerZoneInTheMap)
                {
                    var test = 0;
                }
                if (eventCode == EventCodes.evRegenerationEnergyChanged)
                {
                    var test = 0;
                }
                if (eventCode == EventCodes.evUpdateChatSettings)
                {
                    var test = 0;
                }
                if (eventCode == EventCodes.evRegenerationCraftingChanged)
                {
                    var test = 0;
                }
                if (eventCode == EventCodes.evNewPortalEntrance)
                {
                    var test = 0;
                }
                if (eventCode == EventCodes.evNewPortalExit)
                {
                    var test = 0;
                }

                Console.WriteLine($"MarketEvent => {eventCode} with parameter count : {parameters.Count}");
                var gg = 0;

            }
            catch (Exception e)
            {
                Console.WriteLine($"event fame update ERROR => {e.Message}");
            }
        }
    }
}
