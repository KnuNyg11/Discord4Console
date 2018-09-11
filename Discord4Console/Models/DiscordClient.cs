using Discord4Console.Controllers;
using Discord4Console.Models.JSON;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord4Console.Models
{
    class DiscordClient
    {
        public Discord Discord { get; set; }

        public DiscordUser User { get; set; }
        public List<DiscordUserGuild> UserGuilds { get; set; }

        public List<DiscordGuild> Guilds { get; set; }

        public DiscordClient(string username, string password)
        {
            Discord = new Discord();
            Discord.Login(username, password);

            User = Discord.GetUser();
            UserGuilds = Discord.GetUserGuilds();
            Guilds = Discord.GetGuilds();

            Console.WriteLine(Guilds.Count);
        }

        public void Init()
        {
            User = new DiscordUser();
        }
    }
}
