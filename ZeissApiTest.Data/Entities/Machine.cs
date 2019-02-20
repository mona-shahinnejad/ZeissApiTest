using System;

namespace ZeissApiTest.Data.Entities
{
    public class Machine : BaseEntity
    {
        public string MachineId { get; set; }

        public string PayLoadId { get; set; }

        public DateTime TimeStamp { get; set; }

        public Common.Enums.MachineStatus Status { get; set; }
    }
}
