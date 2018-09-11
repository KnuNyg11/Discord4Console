using Discord4Console.Models;
using Discord4Console.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Discord4Console
{
    class Program
    {
        static void Main(string[] args)
            => new Program();

        public Program()
        {
            new Discord("ninjasploit+discord@gmail.com", "Figaro123");

            Console.ReadLine();
        }

        #region Dev
        JsonSerializerSettings JsonSettings
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

        //new Thread(async() 
        //    => await HeartbeatSerivce()).Start();

        public async Task HeartbeatSerivce(int bufferSize = 1024, bool isDebugging = false)
        {
            ClientWebSocket ws = new ClientWebSocket();
            CancellationToken ct = new CancellationToken();
            ArraySegment<byte> receiveBuffer = new ArraySegment<byte>(new byte[bufferSize]);
            ArraySegment<byte> sendBuffer = new ArraySegment<byte>(new byte[bufferSize]);

            await ws.ConnectAsync(new Uri("wss://gateway.discord.gg/?encoding=json&v=6"), ct);
            while (ws.State == WebSocketState.Connecting)
                Thread.Sleep(10);

            bool hasHeartbeat = false;
            int heartbeatInterval = 0;
            long previousHeartbeat = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            GenericPayload lastPayload = new GenericPayload();

            while(ws.State == WebSocketState.Open)
            {
                if (hasHeartbeat == false)
                {
                    await ws.ReceiveAsync(receiveBuffer, ct);

                    string jsonData = Encoding.ASCII.GetString(receiveBuffer.ToArray()).Replace(" ", "");

                    GatewayPayload gateway = JsonConvert.DeserializeObject<GatewayPayload>(jsonData, JsonSettings);
                    HeartbeatPayload heartbeat = JsonConvert.DeserializeObject<HeartbeatPayload>(gateway.d.ToString(), JsonSettings);

                    lastPayload = new GenericPayload()
                    {
                        op = gateway.op,
                        d = gateway.s,
                    };

                    heartbeatInterval = heartbeat.heartbeat_interval;
                    hasHeartbeat = true;
                }
                else
                {
                    if (previousHeartbeat+heartbeatInterval-1500 <= DateTimeOffset.Now.ToUnixTimeMilliseconds())
                    {
                        GenericPayload payload = new GenericPayload()
                        {
                            op = 1,
                            d = lastPayload.d
                        };

                        string jsonData = JsonConvert.SerializeObject(payload);
                        byte[] data = Encoding.ASCII.GetBytes(jsonData);

                        sendBuffer = new ArraySegment<byte>(data);

                        await ws.SendAsync(sendBuffer, WebSocketMessageType.Text, true, ct);
                        Console.WriteLine("HEARTBEAT");

                        await ws.ReceiveAsync(receiveBuffer, ct);
                        data = receiveBuffer.ToArray();

                        int i = 0;
                        for (i = data.Length - 1; data[i] == 0; i--);

                        byte[] responseData = new byte[i];
                        Buffer.BlockCopy(data, 0, responseData, 0, responseData.Length);

                        jsonData = Encoding.ASCII.GetString(responseData);
                        Console.WriteLine(jsonData);

                        previousHeartbeat = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                    }
                }
                receiveBuffer = new ArraySegment<byte>(new byte[bufferSize]);

                Thread.Sleep(1);
            }
        }
        #endregion
    }
}
