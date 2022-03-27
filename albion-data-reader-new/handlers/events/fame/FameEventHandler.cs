using Albion.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albion_data_reader_new.handlers
{
    public class FameEventHandler : EventPacketHandler<FameEvent>
    {

        public FameEventHandler() : base((int)EventCodes.evUpdateFame)
        {
        }

        protected override async Task OnActionAsync(FameEvent value)
        {
            await Task.CompletedTask;
        }
    }
}
