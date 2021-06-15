using GankCompanionDataReader.eventHandler;
using System;

namespace GankCompanionDataReader.infrastructure
{
    public class InMemoryPartyRepository : IPartyRepository
    {
        //private Guid partyId;
        private string partyId;
        public InMemoryPartyRepository()
        {
        }

        public string GetPartyID()
        {
            return this.partyId;
        }

        public void SetPartyID(string partyId)
        {
            this.partyId = partyId;
        }
    }
}
