using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consume_REST_API.Helpers
{
    public static class ConstantClass
    {
        public class ApiReturnObj
        {
            public dynamic ApiData { get; set; }
            public string Message { get; set; }
            public bool IsExecute { get; set; }
            public int TotalRecord { get; set; }
        }
    }
}
