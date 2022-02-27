using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Helpers.V1
{
    public class ResponseObject
    {
        public dynamic apiData { get; set; }
        public string message { get; set; }
        public dynamic isExexute { get; set; }
    }
}
