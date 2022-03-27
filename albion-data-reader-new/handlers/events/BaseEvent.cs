using albion_data_reader_new;
using System;
using System.Collections.Generic;

namespace Albion.Network
{
    public abstract class BaseEvent
    {
        public Dictionary<byte, object> Parameters { get; set; }
        public EventCodes eventCode { get; set; }
        public BaseEvent(Dictionary<byte, object> parameters)
        {
            this.Parameters = parameters;
            this.eventCode = ParseEventCode(parameters);
        }

        private static EventCodes ParseEventCode(Dictionary<byte, object> parameters)
        {
            if (!parameters.TryGetValue(252, out object value))
            {
                throw new InvalidOperationException();
            }
            try
            {
                short code = (short)value;
                EventCodes test = (EventCodes)code;
                return test;
            }
            catch (Exception)
            {
                return 0;
            }
        }
 
    }
}
