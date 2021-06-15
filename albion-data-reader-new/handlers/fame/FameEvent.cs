using Albion.Network;
using System;
using System.Collections.Generic;

namespace albion_data_reader_new.handlers
{
    public class FameEvent : BaseEvent
    {
        public float BonusFactor;
        public byte GroupSize;
        public bool IsPremiumBonus;
        public int UsedItemType;
        public FameEvent(Dictionary<byte, object> parameters) : base(parameters)
        {
            try
            {
                EventCodes eventCode = Common.ParseEventCode(parameters);
                var gg = 0;

            }
            catch (Exception e)
            {
                Console.WriteLine($"event fame update ERROR => {e.Message}");
            }
        }
    }
}
