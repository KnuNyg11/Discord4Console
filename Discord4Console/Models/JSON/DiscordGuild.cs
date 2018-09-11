using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord4Console.Models.JSON
{
    class DiscordGuild
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }

        public string splash { get; set; }

        public bool owner { get; set; }
        public string owner_id { get; set; }
        public int permissions { get; set; }

        public string region { get; set; }
        public long afk_channel_id { get; set; }
        public string afk_timeout { get; set; }

        public bool embed_enabled { get; set; }
        public string embed_channel_id { get; set; }

        public int verification_level { get; set; }
        public int default_message_notification { get; set; }
        public int explicit_content_filter { get; set; }

        public List<DiscordRole> roles { get; set; }
        public List<DiscordEmoji> emojis { get; set; }
        public List<string> features { get; set; }

        public int mfa_level { get; set; }
        public string application_id { get; set; }

        public bool widget_enabled { get; set; }
        public string widget_channel_id { get; set; }
        public string system_channel_id { get; set; }

        public string joined_at { get; set; }
        public bool large { get; set; }
        public bool unavailable { get; set; }
        public int member_count { get; set; }

        public List<DiscordVoiceState> voice_states { get; set; }
        public List<DiscordGuildMember> members { get; set; }
        public List<DiscordGuildChannel> channels { get; set; }
        public List<DiscordPresence> presences { get; set; }
    }
}
