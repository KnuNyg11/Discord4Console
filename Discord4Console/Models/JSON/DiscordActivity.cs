using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord4Console.Models.JSON
{
    class DiscordActivity
    {
        public string name { get; set; }
        public int type { get; set; }
        public string url { get; set; }
        public DiscordActivityTimestamps timestamps { get; set; }
        public string application_id { get; set; }
        public string details { get; set; }
        public string state { get; set; }
        public DiscordParty party { get; set; }
        public DiscordAssets assets { get; set; }
        public DiscordSecrets secrets { get; set; }
        public bool instance { get; set; }
        public int flags { get; set; }
    }

    class DiscordActivityTimestamps
    {
        public int start { get; set; }
        public int end { get; set; }
    }
}
