using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord4Console.Models.JSON
{
    class DiscordUserGuild
    {
        public string id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }

        public int permissions { get; set; }
        public bool owner { get; set; }
    }
}
