using Albion.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albion_data_reader_new.handlers
{
    public class AllEventHandler : EventPacketHandler<AllEvent>
    {
        private static readonly List<int> eventCodes = new()
        {
   
        };
        public AllEventHandler() : base(eventCodes)
        {
            //this.MustIgnoreSomeEvents = false;
            this.OverwriteEventCodesToIgnore();
        }

        protected override async Task OnActionAsync(AllEvent value)
        {
            EventCodes eventCodes = value.eventCode;
            string eventName = eventCodes.ToString();
            if (eventCodes == EventCodes.evMailNotification)
            {
                var ee = "here";
            }
      
            await Task.CompletedTask;
        }
        private void OverwriteEventCodesToIgnore()
        {
            List<int> eventsToIgnore = new()
            {
                (int)EventCodes.evOpenChest,
                (int)EventCodes.evCharacterEquipmentChanged,
                (int)EventCodes.evMountStart,
                (int)EventCodes.evSiegeCampScheduleResult,
                (int)EventCodes.evPlayerLogsIn,
                (int)EventCodes.evInvitedToGuild,
                (int)EventCodes.evTimeSync,
                (int)EventCodes.evCastHit,
                (int)EventCodes.evNewJournalItem,
                (int)EventCodes.evSplitItemStack,

            };
            this.eventCodesToIgnore = eventsToIgnore;
        }
    }
}
