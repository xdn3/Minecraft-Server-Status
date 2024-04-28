using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Server_Status.Structs
{
    internal class ServerInfo
    {
        [JsonProperty("online")]
        public bool? online { get; set; }
        [JsonProperty("ip")]
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        public string? ip { get; set; }
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        [JsonProperty("port")]
        public int? port { get; set; }
        [JsonProperty(propertyName: "debug")]
        public Debug debug { get; set; }
        [JsonProperty(propertyName: "motd")]
        public Dictionary<string, List<string>> motd { get; set; }
        [JsonProperty("players")]
        public Players players { get; set; }
        [JsonProperty("version")]
        public string? version { get; set; }
        [JsonProperty("protocol")]
        public int? protocol { get; set; }
        [JsonProperty("hostname")]
        public string? hostname { get; set; }
        [JsonProperty("icon")]
        public string? icon { get; set; }
        [JsonProperty("software")]
        public string? software { get; set; }
        [JsonProperty("map")]
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        public string? map { get; set; }
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        [JsonProperty("gamemode")]
        public string? gamemode { get; set; }
        [JsonProperty("serverid")]
        public string? serverid { get; set; }
        [JsonProperty("plugins")]
        public Plugins? plugins { get; set; }
        [JsonProperty("mods")]
        public Mods? mods { get; set; }
        [JsonProperty("info")]
        public Info? info { get; set; }
    }
    internal class Players
    {
        [JsonProperty("online")]
        public int? online { get; set; }
        [JsonProperty("max")]
        public int? max { get; set; }
        [JsonProperty("list")]
        public List<string>? list { get; set; }
        [JsonProperty("uuid")]
        public Dictionary<string, string>? uuid { get; set; }
    }
    internal class Mods
    {
        [JsonProperty("names")]
        public List<string> names { get; set; }
        [JsonProperty("raw")]
        public List<string> raw { get; set; }
    }
    internal class Plugins
    {
        [JsonProperty("names")]
        public List<string> names { get; set; }
        [JsonProperty("raw")]
        public List<string> raw { get; set; }
    }
    internal class Info
    {
        [JsonProperty("raw")]
        public List<string> raw { get; set; }
        [JsonProperty("clean")]
        public List<string> clean { get; set; }
        [JsonProperty("html")]
        public List<string> html { get; set; }
    }
    public class Debug
    {
        [JsonProperty("ping")]
        public bool? ping { get; set; }
        [JsonProperty("query")]
        public bool? query { get; set; }
        [JsonProperty("srv")]
        public bool? srv { get; set; }
        [JsonProperty("querymismatch")]
        public bool? querymismatch { get; set; }
        [JsonProperty("ipinsrv")]
        public bool? ipinsrv { get; set; }
        [JsonProperty("cnameinsrv")]
        public bool? cnameinsrv { get; set; }
        [JsonProperty("animatedmotd")]
        public bool? animatedmotd { get; set; }
        [JsonProperty("cachetime")]
        public long? cachetime { get; set; }
    }
}