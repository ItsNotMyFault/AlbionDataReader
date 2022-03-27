using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Albion.Network.Example
{
    public class MoveEventHandler : EventPacketHandler<MoveEvent>
    {
        private static readonly List<int> evetnCodes = new List<int>() {
            (int)EventCodes.evZonethroughNewZone,
            (int)EventCodes.evPlayerZoneInTheMap,

        };
        public MoveEventHandler() : base(evetnCodes) { }

        protected override Task OnActionAsync(MoveEvent value)
        {
            if (value.someoneZoned)
            {
                Console.WriteLine($"SOMEONE ZONED IN THE MAP, count =  {value.paramCount}");
            }
            
            return Task.CompletedTask;
        }
    }
}
