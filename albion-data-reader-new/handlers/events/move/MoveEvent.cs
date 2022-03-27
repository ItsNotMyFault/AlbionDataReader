using System;
using System.Collections.Generic;

namespace Albion.Network.Example
{
    public class MoveEvent : BaseEvent
    {
        public bool someoneZoned = false;
        public int paramCount = 0;
        public MoveEvent(Dictionary<byte, object> parameters) : base(parameters)
        {
            this.paramCount = parameters.Count;
            if (this.paramCount > 6)
            {

                this.someoneZoned = true;

                if (this.paramCount == 10)
                {
                    var tt = 0;
                }
                else if (this.paramCount == 11)
                {
                    var tt = 0;
                }
                else if (this.paramCount == 12)
                {
                    var tt = 0;
                }
            }
        }

    }
}
