using ZeissApiTest.Business.Dto;

namespace ZeissApiTest.Business.IService
{
    public interface IMachineWebSocketService
    {
        void RecieveData(MachineWebSocketDto data);
    }
}
