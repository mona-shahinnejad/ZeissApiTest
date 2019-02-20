using System.Collections.Generic;
using Newtonsoft.Json;

namespace ZeissApiTest.Business.Dto
{
    public class MachineWebSocketDto
    {
        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("ref")]
        public string Reference { get; set; }

        [JsonProperty("payload")]
        public MachineDto Machine { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }
    }
}
