using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System;
using Newtonsoft.Json;
using System.IO;

namespace Minecraft_Server_Status
{
    internal class Api
    {
        public static async Task<Structs.ServerInfo> GetInfoJava(string address)
        {
            HttpClient client = new();
            HttpResponseMessage resp = client.GetAsync($"https://api.mcsrvstat.us/2/{address}").Result;
            string responseBody = await resp.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Structs.ServerInfo>(responseBody);
        }
        public static async Task<Structs.ServerInfo> GetInfoBedrock(string address)
        {
            HttpClient client = new();
            HttpResponseMessage resp = await client.GetAsync($"https://api.mcsrvstat.us/bedrock/2/{address}");
            string responseBody = await resp.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Structs.ServerInfo>(responseBody);
        }
    }
}