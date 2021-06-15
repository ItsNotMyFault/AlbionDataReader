using albion_data_reader_new;
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
            EventCodes anEventZonetrhoughMap = (EventCodes)packet.EventCode;
            if (EventCodes.evPlayerZoneInTheMap == anEventZonetrhoughMap
                || EventCodes.evZonethroughNewZone == anEventZonetrhoughMap)
            {
                if (packet.Parameters.Count > 6)
                {
                    Console.WriteLine($"SOMEONE ZONED IN THE MAP, count =  {packet.Parameters.Count}");
                }

            }
            if (eventCodesToIgnore.Contains(packet.EventCode))
            {
                return NextAsync(packet);
            }
            if (eventCodes != null && eventCodes.Count > 0)
            {
                if (eventCodes.Contains(packet.EventCode))
                {
                    TEvent instance = (TEvent)Activator.CreateInstance(typeof(TEvent), packet.Parameters);

                    return OnActionAsync(instance);
                }
            }
            if (eventCode != packet.EventCode)
            {
                EventCodes eventCodes = (EventCodes)packet.EventCode;
                //Console.WriteLine($"Unregisteered Event => {eventCodes} with parameter count : {packet.Parameters.Count}");
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
                (int) EventCodes.evPlayerZoneInTheMap,
                (int) EventCodes.evMove,
                (int) EventCodes.evMove3,
                (int) EventCodes.evevLeave,
                (int) EventCodes.evUnknown,
                (int) EventCodes.evUnknown2,
                (int) EventCodes.evUnknown3,
                (int) EventCodes.evPlayerGetonline,
                (int) EventCodes.evUpdateFame,
                (int) EventCodes.evZonethroughNewZone,
                (int) EventCodes.evPartyFinderUpdate,
                (int) EventCodes.evUnknown4,
                (int) EventCodes.evNewEquipmentItem,
                (int) EventCodes.evSiegeCampClaimStart,
                (int) EventCodes.evSiegeCampClaimCancel,
                (int) EventCodes.evOtherGrabbedLoot,
                (int) EventCodes.evActionOnBuildingStart,
                (int) EventCodes.evPremiumChanged,
                (int) EventCodes.evDurabilityChanged,
                (int) EventCodes.evAccessStatus,
                (int) EventCodes.evRegenerationEnergyChanged,
                (int) EventCodes.evUpdateChatSettings,
                (int) EventCodes.evStopsMoving,       //fightingevents below
                (int) EventCodes.evCastHit,
                (int) EventCodes.evExitEnterCancel,
                (int) EventCodes.evActiveSpellEffectsUpdate,
                (int) EventCodes.evCastHits,
                (int) EventCodes.evCastSpell,
                (int) EventCodes.evCastSpell2,
                (int) EventCodes.evEnergyUpdate,
                (int) EventCodes.evChannelingEnded,
                (int) EventCodes.evDamageShieldUpdate,
                (int) EventCodes.evCharacterStatsDeathHistory,
                (int) EventCodes.evCastStart,
                (int) EventCodes.evRegenerationHealthChanged,
            };
            this.eventCodesToIgnore = eventsToIgnore;
        }
    }
}
