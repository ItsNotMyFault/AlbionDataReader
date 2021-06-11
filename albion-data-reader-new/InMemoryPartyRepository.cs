using GankCompanionDataReader.eventHandler;
using System;

namespace GankCompanionDataReader.infrastructure
{
    public class InMemoryPartyRepository : IPartyRepository
    {
        private Guid partyId;
        public InMemoryPartyRepository()
        {
            this.partyId = Guid.NewGuid();
            
        }

        public Guid GetPartyID()
        {
            return this.partyId;
        }

        public string GetPartyIDString()
        {
            return this.partyId.ToString();
        }

        public void SetPartyID(string partyId)
        {
            this.partyId = new Guid(partyId);
        }
    }
}
