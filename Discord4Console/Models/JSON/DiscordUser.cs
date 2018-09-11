using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord4Console.Models.JSON
{
    class DiscordUser
    {
        public string username { get; set; }
        public string email { get; set; }
        public int phone { get; set; }

        public string id { get; set; }
        public int discriminator { get; set; }
        public string avatar { get; set; }

        public bool verified { get; set; }
        public bool mfa_enabled { get; set; }
        public int flags { get; set; }
        public string locale { get; set; }
    }
}
