using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord4Console.Models.JSON
{
    class DiscordPresence
    {
        public DiscordGuildUser user { get; set; }
        public List<string> roles { get; set; }
        public DiscordActivity game { get; set; }
        public string guild_id { get; set; }
        public string status { get; set; }
    }
}
