using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord4Console.Models.JSON
{
    class DiscordRateLimit
    {
        public string message { get; set; }
        public int retry_after { get; set; }
        public bool global { get; set; }
    }
}
