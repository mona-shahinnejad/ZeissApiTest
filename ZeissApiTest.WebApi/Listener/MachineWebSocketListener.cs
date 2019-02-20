using System;
using System.Configuration;
using WebSocketSharp;
using ZeissApiTest.Business.Dto;
using ZeissApiTest.Business.IService;

namespace ZeissApiTest.WebApi.Listener
{
    public class MachineWebSocketListener
    {
        private readonly IMachineWebSocketService _machineWebSocketService;

        private const string MachineWebSocketAddressConfigName = "MachineWebSocketAddress";

        public MachineWebSocketListener(IMachineWebSocketService machineWebSocketService)
        {
            _machineWebSocketService = machineWebSocketService;
        }

        private void Ws_OnMessage(object sender, MessageEventArgs e)
        {
            _machineWebSocketService.RecieveData(Newtonsoft.Json.JsonConvert.DeserializeObject<MachineWebSocketDto>(e.Data));
        }

        internal void Start()
        {
            var ws = new WebSocket(ConfigurationManager.AppSettings[MachineWebSocketAddressConfigName]);

            ws.OnMessage += Ws_OnMessage;

            ws.Connect();
        }
    }
}