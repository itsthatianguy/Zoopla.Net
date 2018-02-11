using Newtonsoft.Json;

namespace Zoopla.Net.Core.Models.Session
{
    public class SessionResponse : ResponseModelBase
    {
        [JsonProperty("session_id")]
        public string SessionId { get; set; }
    }
}
