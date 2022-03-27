using Albion.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albion_data_reader_new.handlers.requests
{
    public class AllRequestsHandler : RequestPacketHandler<AllOperation>
    {
        public AllRequestsHandler(int operationCode) : base(operationCode)
        {
            var test = operationCode;
        }

        protected override async Task OnActionAsync(AllOperation value)
        {
            if(value == null)
            {
                return;
            }
            OperationCodes eventCodes = value.operationCode;
            string eventName = eventCodes.ToString();

            await Task.CompletedTask;
        }
    }
}
