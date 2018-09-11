using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord4Console.Models.JSON
{
    class DiscordGuildMember
    {
        public DiscordGuildUser user { get; set; }
        public string nick { get; set; }
        public List<string> roles { get; set; }
        public string joined_at { get; set; }
        public bool deaf { get; set; }
        public bool mute { get; set; }
    }
}
