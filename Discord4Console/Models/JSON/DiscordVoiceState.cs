using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord4Console.Models.JSON
{
    class DiscordVoiceState
    {
        public string guild_id { get; set; }
        public string channel_id { get; set; }
        public string user_id { get; set; }
        public string session_id { get; set; }
        public bool deaf { get; set; }
        public bool mute { get; set; }
        public bool self_deaf { get; set; }
        public bool self_mute { get; set; }
        public bool suppress { get; set; }
    }
}
