namespace ZeissApiTest.Data.Entities
{
    public class MachineHistory : BaseEntity
    {
        public Common.Enums.MachineEvent Event { get; set; }

        public string MachineId { get; set; }

        public string PayLoadId { get; set; }

        public System.DateTime TimeStamp { get; set; }

        public Common.Enums.MachineStatus Status { get; set; }
    }
}
