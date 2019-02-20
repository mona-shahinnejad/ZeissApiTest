using System;

namespace ZeissApiTest.Business.Dto
{
    public class MachineHistoryDto
    {
        public Common.Enums.MachineEvent Event { get; set; }

        public string MachineId { get; set; }

        public string PayLoadId { get; set; }

        public DateTime TimeStamp { get; set; }

        public Common.Enums.MachineStatus Status { get; set; }
    }
}
