using System;
using System.Collections.Generic;
using System.Text;

namespace GankCompanionDataReader.eventHandler
{
    public interface IPartyRepository
    {

        string GetPartyID();
        void SetPartyID(string partyId);
        
    }
}
