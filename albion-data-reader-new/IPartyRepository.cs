using System;
using System.Collections.Generic;
using System.Text;

namespace GankCompanionDataReader.eventHandler
{
    public interface IPartyRepository
    {

        string GetPartyIDString();
        Guid GetPartyID();
        void SetPartyID(string partyId);
    }
}
