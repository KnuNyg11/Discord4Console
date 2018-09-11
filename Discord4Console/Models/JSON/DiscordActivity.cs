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
        public DiscordActivityParty party { get; set; }
        public DiscordActivityAssets assets { get; set; }
        public DiscordActivitySecrets secrets { get; set; }
        public bool instance { get; set; }
        public int flags { get; set; }
    }
}
