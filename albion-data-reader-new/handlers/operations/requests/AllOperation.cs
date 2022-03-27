using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albion_data_reader_new.handlers.requests
{
    public class AllOperation : BaseOperation
    {
    
        public AllOperation(Dictionary<int, object> parameters) : base(parameters)
        {
            try
            {
                Console.WriteLine($"AllOperation => with parameter count : {parameters.Count}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"EXCEPTION PARTY MANAGER => {e.Message}");
            }

        }
    }
}
