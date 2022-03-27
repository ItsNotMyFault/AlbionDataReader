using Albion.Network;
using System;
using System.Collections.Generic;
using System.Linq;

namespace albion_data_reader_new.handlers
{
    public class AllEvent : BaseEvent
    {
        public AllEvent(Dictionary<byte, object> parameters) : base(parameters)
        {
            try
            {
                int codeNumber = (int)this.eventCode;
                Console.WriteLine($"AllEvent => ({codeNumber}){this.eventCode} with parameter count : {parameters.Count}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"EXCEPTION PARTY MANAGER => {e.Message}");
            }

        }
    }
}
