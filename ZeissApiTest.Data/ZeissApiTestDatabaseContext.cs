using ZeissApiTest.Data.Entities;
using System.Data.Entity;

namespace ZeissApiTest.Data
{
    public class ZeissApiTestDatabaseContext : DbContext
    {
        public ZeissApiTestDatabaseContext()
            : base("ZeissApiTest")
        {
        }

        public DbSet<Machine> Machine { get; set; }

        public DbSet<MachineHistory> MachineHistory { get; set; }
    }
}
