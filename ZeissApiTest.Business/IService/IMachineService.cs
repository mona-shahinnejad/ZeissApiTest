using System.Collections.Generic;
using ZeissApiTest.Business.Dto;

namespace ZeissApiTest.Business.IService
{
    public interface IMachineService
    {
        void SaveMachineData(MachineDto machine);
        void SaveMachineDataHistory(MachineHistoryDto machineHistory);
        IList<MachineDto> GetAllMachines();
        MachineDto GetMachineById(string machineId);
        string GetMachineStatus(string machineId);
    }
}
