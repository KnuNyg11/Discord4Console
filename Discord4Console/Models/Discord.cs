using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord4Console.Models.JSON;
using Newtonsoft.Json;

namespace Discord4Console.Models
{
    class Discord
    {
        NetClient Client { get; set; }
        JsonSerializerSettings JSONSettings
        {
            get
            {
                return new JsonSerializerSettings()
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore
                };
            }
        }

        public Discord(string email, string password)
        {
            Client = new NetClient();

            string loginData = JsonConvert.SerializeObject(new LoginRequest(email, password));
            string authToken = JsonConvert.DeserializeObject<LoginResponse>(Client.Post(DiscordURL.LoginURL, loginData)).token;

            Client.AddHeader("authorization", authToken);

            Console.WriteLine(JsonConvert.DeserializeObject<List<DiscordUserGuild>>(Client.Get(DiscordURL.GuildsURL))[0].id);
        }
    }

    class DiscordURL
    {
        public const string BaseURL = "https://discordapp.com/api/v6";

        /// <summary>
        /// A POST request to this URL with a JSON Serialized /JSON/LoginRequest object 
        /// results in a JSON Serialized /JSON/LoginResponse object. (Authentication Token)
        /// </summary>
        public static string LoginURL = $"{BaseURL}/auth/login";

        /// <summary>
        /// A GET request to this URL results in a JSON Serialized /JSON/DiscordUser object
        /// </summary>
        public static string UserURL = $"{BaseURL}/users/@me";

        /// <summary>
        /// A GET request to this URL results in a JSON Serialized List(/JSON/DiscordGuild) object
        /// </summary>
        public static string GuildsURL = $"{BaseURL}/users/@me/guilds";
        /// <summary>
        /// A GET requests to this URL results in a JSON Serialized List(/JSON/DiscordGuildChannel) object
        /// </summary>
        /// <param name="guild"></param>
        /// <returns>API EndPoint for Guild's Channels</returns>
        public static string GuildChannelsURL(DiscordUserGuild guild)
        {
            return $"{BaseURL}/guilds/{guild.id}/channels";
        }
        /// <summary>
        /// A GET requests to this URL results in a JSON Serialized List(/JSON/DiscordGuildChannel) object
        /// </summary>
        /// <param name="guild"></param>
        /// <returns>API EndPoint for Guild's Channels</returns>
        public static string GuildChannelsURL(string guildID)
        {
            return $"{BaseURL}/guilds/{guildID}/channels";
        }
    }
}
