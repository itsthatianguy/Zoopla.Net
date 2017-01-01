using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoopla.Net.Models
{
    public class SessionResponse : ResponseModelBase
    {
        [JsonProperty("session_id")]
        public string SessionId { get; set; }
    }
}
