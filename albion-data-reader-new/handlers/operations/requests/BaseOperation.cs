using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albion_data_reader_new.handlers.requests
{
    public abstract class BaseOperation
    {
        public Dictionary<int, object> Parameters { get; set; }
        public OperationCodes operationCode { get; set; }
        public BaseOperation(Dictionary<int, object> parameters)
        {
            this.Parameters = parameters;
            this.operationCode = ParseEventCode(parameters);
        }


        private static OperationCodes ParseEventCode(Dictionary<int, object> parameters)
        {
            if (!parameters.TryGetValue(308, out object value))
            //if (!parameters.TryGetValue(252, out object value))
            {
                throw new InvalidOperationException();
            }
            try
            {
                short code = (short)value;
                OperationCodes test = (OperationCodes)code;
                return test;
            }
            catch (Exception)
            {
                return 0;
            }
        }

    }

}
