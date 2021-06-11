using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Albion.Network
{
    public abstract class EventPacketHandler<TEvent> : PacketHandler<EventPacket> where TEvent : BaseEvent
    {
        private readonly int eventCode;
        private readonly List<int> eventCodes;
        private List<int> eventCodesToIgnore;

        public EventPacketHandler(int eventCode)
        {
            this.eventCode = eventCode;
            SetEventCodesToIgnore();
        }

        public EventPacketHandler(List<int> eventCodes)
        {
            this.eventCodes = eventCodes;
            SetEventCodesToIgnore();
        }

        protected abstract Task OnActionAsync(TEvent value);

        protected internal override Task OnHandleAsync(EventPacket packet)
        {
            if (eventCodesToIgnore.Contains(packet.EventCode))
            {
                return NextAsync(packet);
            }
            if (eventCodes!= null && eventCodes.Count > 0)
            {
                if (eventCodes.Contains(packet.EventCode))
                {
                    TEvent instance = (TEvent)Activator.CreateInstance(typeof(TEvent), packet.Parameters);

                    return OnActionAsync(instance);
                }
            }
            if (eventCode != packet.EventCode)
            {
                return NextAsync(packet);
            }
            else
            {
                TEvent instance = (TEvent)Activator.CreateInstance(typeof(TEvent), packet.Parameters);

                return OnActionAsync(instance);
            }
        }

        private void SetEventCodesToIgnore()
        {
            List<int> eventsToIgnore = new List<int>() { 
                0,
                (int) EventCodes.evMove,
                (int) EventCodes.evevLeave,
                (int) EventCodes.evUnknown,
                (int) EventCodes.evUnknown2,
                (int) EventCodes.evUnknown3,
                (int) EventCodes.evPlayerGetonline,
            };
            this.eventCodesToIgnore = eventsToIgnore;
        }
    }
}
