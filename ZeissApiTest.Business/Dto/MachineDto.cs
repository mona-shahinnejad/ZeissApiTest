using System;
using Newtonsoft.Json;

namespace ZeissApiTest.Business.Dto
{
    public class MachineDto
    {
        [JsonProperty("machine_id")]
        public string MachineId { get; set; }

        [JsonProperty("id")]
        public string PayLoadId { get; set; }

        [JsonProperty("timestamp")]
        public DateTime TimeStamp { get; set; }

        [JsonProperty("status")]
        public Common.Enums.MachineStatus Status { get; set; }
    }
}
