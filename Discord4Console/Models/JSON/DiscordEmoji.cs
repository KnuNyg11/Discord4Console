using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord4Console.Models.JSON
{
    class DiscordEmoji
    {
        public string id { get; set; }
        public string name { get; set; }
        public List<DiscordRole> roles { get; set; }
        public DiscordGuildUser user { get; set; }
        public bool require_colons { get; set; }
        public bool managed { get; set; }
        public bool animated { get; set; }
    }
}
