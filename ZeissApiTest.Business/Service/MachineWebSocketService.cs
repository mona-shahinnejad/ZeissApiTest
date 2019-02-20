using System;
using AutoMapper;
using ZeissApiTest.Business.Dto;
using ZeissApiTest.Business.IService;
using ZeissApiTest.Common.Enums;

namespace ZeissApiTest.Business.Service
{
    internal class MachineWebSocketService : IMachineWebSocketService
    {
        private readonly IMachineService _machineService;
        private readonly IMapper _mapper;

        public MachineWebSocketService(
            IMachineService machineService,
            IMapper mapper)
        {
            _machineService = machineService;
            _mapper = mapper;
        }

        public void RecieveData(MachineWebSocketDto data)
        {
            _machineService.SaveMachineData(data.Machine);

            var machineHistory = _mapper.Map<MachineHistoryDto>(data.Machine);
            machineHistory.Event = Enum.TryParse(data.Event, out MachineEvent machineEvent) ? machineEvent : MachineEvent.unknown;
            _machineService.SaveMachineDataHistory(machineHistory);
        }
    }
}
