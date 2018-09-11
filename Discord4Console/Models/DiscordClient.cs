using Discord4Console.Models.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord4Console.Models
{
    class DiscordClient
    {
        public DiscordUser User { get; set; }
        public List<DiscordUserGuild> Guilds { get; set; }
    }
}
