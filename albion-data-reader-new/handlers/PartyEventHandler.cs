using Albion.Network;
using GankCompanionDataReader.eventHandler;
using GankCompanionDataReader.eventHandler.party;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albion_data_reader_new.handlers
{
    public class PartyEventHandler : EventPacketHandler<PartyEvent>
    {
        private readonly PartyApiService partyApiService;

        private static readonly List<int> evetnCodes = new List<int>() {
            (int)EventCodes.evPartyPlayerJoined,
            (int)EventCodes.evPartyCreated,
            (int)EventCodes.evPartyPlayerLeft
        };
        public PartyEventHandler(PartyApiService partyApiService) : base(evetnCodes)
        {
            this.partyApiService = partyApiService;
        }

        protected override async Task OnActionAsync(PartyEvent value)
        {

            if(value.partyJoinEvent != null)
            {
                PartyJoinEvent partyJoinEvent = value.partyJoinEvent;
                this.partyApiService.PlayerJoinParty(partyJoinEvent);
            }else if(value.partyCreateEvent != null)
            {
                PartyCreateEvent partyCreateEvent = value.partyCreateEvent;
                this.partyApiService.CreateParty(partyCreateEvent);
            } else if (value.partyLeftEvent != null)
            {
                PartyLeftEvent partyLeftEvent = value.partyLeftEvent;
                this.partyApiService.PlayerLeaveParty(partyLeftEvent);
            }
            await Task.CompletedTask;
        }
    }
}
