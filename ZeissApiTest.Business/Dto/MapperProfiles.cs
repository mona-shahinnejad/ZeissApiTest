using AutoMapper;
using ZeissApiTest.Data.Entities;

namespace ZeissApiTest.Business.Dto
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<Machine, MachineDto>().ReverseMap();
            CreateMap<MachineHistory, MachineHistoryDto>().ReverseMap();
            CreateMap<MachineDto, MachineHistoryDto>().ReverseMap();
        }
    }
}
