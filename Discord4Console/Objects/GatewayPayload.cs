using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord4Console.Objects
{
    class GatewayPayload
    {
        public int op { get; set; }
        public int s { get; set; }
        public int t { get; set; }
        public object d { get; set; }
    }
}
