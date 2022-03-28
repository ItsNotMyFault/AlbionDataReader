using albion_data_reader_new.handlers.requests;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Albion.Network
{
    public abstract class ResponsePacketHandler<TOperation> : PacketHandler<ResponsePacket> where TOperation : BaseOperation
    {
        private readonly int operationCode;
        protected List<int> operationCodesToIgnore;
        public ResponsePacketHandler(int operationCode)
        {
            this.operationCode = operationCode;
            SetOperationCodesToIgnore();
        }

        protected abstract Task OnActionAsync(TOperation value);

        protected internal override Task OnHandleAsync(ResponsePacket packet)
        {
            if (operationCodesToIgnore.Contains(packet.OperationCode))
            {
                return NextAsync(packet);
            }
            OperationCodes operationCode = (OperationCodes)packet.OperationCode;
            string operationName = operationCode.ToString();
            TOperation instance = null;
            try
            {
                Dictionary<int, object> newParameters = ConvertParameters(packet.Parameters);
                instance = (TOperation)Activator.CreateInstance(typeof(TOperation), packet.Parameters);
            }
            catch(Exception ex)
            {
                var exception = ex;
            }


            return OnActionAsync(instance);

        }
        private Dictionary<int, object> ConvertParameters(Dictionary<byte, object> oldParameters)
        {
            Dictionary<int, object> newParameters = new();
            foreach (KeyValuePair<byte, object> item in oldParameters)
            {
                byte byteValue = item.Key;
                int result = (int)(byteValue);
                newParameters.Add(result, item.Value);
            }
            return newParameters;
        }
        private void SetOperationCodesToIgnore()
        {
            List<int> eventsToIgnore = new()
            {
                (int)OperationCodes.UnknownX,
            };
            this.operationCodesToIgnore = eventsToIgnore;
        }
    }
}
