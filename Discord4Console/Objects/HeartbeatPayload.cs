using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord4Console.Objects
{
    class HeartbeatPayload
    {
        public int heartbeat_interval { get; set; }
        public string[] _trace { get; set; }
    }
}
