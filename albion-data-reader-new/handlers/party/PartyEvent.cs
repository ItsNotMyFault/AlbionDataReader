using Albion.Network;
using System;
using System.Collections.Generic;
using System.Linq;

namespace albion_data_reader_new.handlers
{
    public class PartyEvent : BaseEvent
    {
        public PartyCreateEvent partyCreateEvent;
        public PartyJoinEvent partyJoinEvent;
        public PartyLeftEvent partyLeftEvent;
        public PartyEvent(Dictionary<byte, object> parameters) : base(parameters)
        {
            try
            {
                EventCodes eventCode = Common.ParseEventCode(parameters);

                if (eventCode == EventCodes.evPartyCreated)
                {
                    InitPartyCreateEvent(parameters);
                }
                else if (eventCode == EventCodes.evPartyPlayerJoined)
                {
                    InitPartyJoinEvent(parameters);
                }
                else if (eventCode == EventCodes.evPartyPlayerLeft)
                {
                    InitPartyLeftEvent(parameters);
                }
                Console.WriteLine($"PartyEvent => {eventCode} with parameter count : {parameters.Count}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"EXCEPTION PARTY MANAGER => {e.Message}");
            }

        }

        private void InitPartyCreateEvent(Dictionary<byte, object> parameters)
        {
            if (parameters.Count != 11)
            {
                return;
            }
            dynamic playerArrayId = parameters[4];
            var player1Id = playerArrayId[0];
            var player2Id = playerArrayId[1];

            dynamic playerArrayNames = parameters[5];
            var player1Name = playerArrayNames[0];
            var player2Name = playerArrayNames[1];

            Guid partyId = Guid.NewGuid();
            this.partyCreateEvent = new PartyCreateEvent()
            {
                PartyId = partyId,
                Player1Id = ConvertByteArrayToString(player1Id),
                Player1Name = player1Name,
                Player2Id = ConvertByteArrayToString(player2Id),
                Player2Name = player2Name,
                PartyStartTime = DateTime.Now.ToString("yyy-MM-dd HH:mm:ss")
            };


        }

        private void InitPartyJoinEvent(Dictionary<byte, object> parameters)
        {
            dynamic playerName = new object();
            dynamic playerId = new Object();
            parameters.TryGetValue(1, out playerId);
            parameters.TryGetValue(2, out playerName);
            this.partyJoinEvent = new PartyJoinEvent()
            {
                PlayerJoinedId = ConvertByteArrayToString(playerId),
                PlayerJoinedName = playerName,
            };
        }

        private void InitPartyLeftEvent(Dictionary<byte, object> parameters)
        {
            if (parameters.Count == 1)//player deny invite.
            {
                return;
            }
            else if (parameters.Count == 2)//set party as closed
            {
                //this.partyService.PlayerCloseParty();
                this.partyLeftEvent = new PartyLeftEvent()
                {
                    IsPartyClosed = true
                };
            }
            else if (parameters.Count == 3)//specific player left party.
            {
                dynamic partyMemberByteArray = new Object();
                parameters.TryGetValue(1, out partyMemberByteArray);
                this.partyLeftEvent = new PartyLeftEvent()
                {
                    PlayerLeftId = partyMemberByteArray,
                    IsPartyClosed = false
                };
            }
        }

        private string ConvertByteArrayToString(byte[] buffer)
        {
            string result = "";
            try
            {
                result = string.Join(";", buffer);
                string[] str = result.Split(";");

                //to convertback
                int[] myInts = str.Select(int.Parse).ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine($"EXCEPTION PARTY MANAGER => {e.Message}");
            }


            return result;
        }
    }
}
