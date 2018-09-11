using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord4Console.Models.JSON
{
    class DiscordRole
    {
        public string id { get; set; }
        public string name { get; set; }
        public int color { get; set; }
        public bool hoist { get; set; }
        public int position { get; set; }
        public int permissions { get; set; }
        public bool managed { get; set; }
        public bool mentionable { get; set; }
    }
}
