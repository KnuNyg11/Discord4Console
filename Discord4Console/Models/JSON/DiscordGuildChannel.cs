using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord4Console.Models.JSON
{
    class DiscordGuildChannel
    {
        public string id { get; set; }
        public int type { get; set; }
        public string guild_id { get; set; }
        public int position { get; set; }
        public List<DiscordChannelOverwrite> permission_overwrites { get; set; }
        public string name { get; set; }
        public string topic { get; set; }
        public bool nsfw { get; set; }
        public string last_message_id { get; set; }
        public int bitrate { get; set; }
        public int user_limit { get; set; }
        public List<DiscordGuildUser> recipients { get; set; }
        public string icon { get; set; }
        public string owner_id { get; set; }
        public string application_id { get; set; }
        public string parent_id { get; set; }
        public string last_pin_timestamp { get; set; }
    }
}
