using VersionDemo.Models;

namespace VersionDemo.Services
{
    public class DeviceService : IDeviceService
    {
        public IQueryable<ThermostatV1> RetrieveAllDevicesV1() 
        {
            return new List<ThermostatV1> { 

                new ThermostatV1()
                {
                    Port = "USB1"
                },
                new ThermostatV1()
                {
                    Port = "USB2"
                },
                new ThermostatV1()
                {
                    Port = "MicroUsb"
                },

            }.AsQueryable(); }

        public IQueryable<ThermostatV2> RetrieveAllDevicesV2()
        {
            return new List<ThermostatV2> {

                new ThermostatV2()
                {
                    Port = "USB1",
                    Wireless = "Bluetooth"
                },
                new ThermostatV2()
                {
                    Port = "USB2",
                    Wireless = "BLE"
                },
                new ThermostatV2()
                {
                    Port = "MicroUsb",
                    Wireless = "Wifi"
                },

            }.AsQueryable();
        }
    }
}
