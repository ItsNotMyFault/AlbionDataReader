using Albion.Network;
using GankCompanionDataReader.eventHandler.party;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace albion_data_reader_new.handlers
{
    public class PartyEventHandler : EventPacketHandler<PartyEvent>
    {
        private readonly PartyApiService partyApiService;

        private static readonly List<int> eventCodes = new List<int>() {
            (int)EventCodes.evPartyPlayerJoined,
            (int)EventCodes.evPartyCreated,
            (int)EventCodes.evPartyPlayerLeft
        };
        public PartyEventHandler(PartyApiService partyApiService) : base(eventCodes)
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
                if (value.partyLeftEvent.IsPartyClosed)
                {
                    this.partyApiService.CloseParty();
                }
                else
                {
                  
                    this.partyApiService.PlayerLeaveParty(partyLeftEvent);
                }
         
            }
            await Task.CompletedTask;
        }
    }
}
