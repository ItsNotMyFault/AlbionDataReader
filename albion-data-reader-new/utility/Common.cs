using Albion.Network;
using System;
using System.Collections.Generic;

namespace albion_data_reader_new
{
    public static class Common
    {

        public static EventCodes ParseEventCode(Dictionary<byte, object> parameters)
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
