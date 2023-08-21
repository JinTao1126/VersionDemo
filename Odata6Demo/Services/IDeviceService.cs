using VersionDemo.Models;

namespace VersionDemo.Services
{
    public interface IDeviceService
    {
        IQueryable<ThermostatV1> RetrieveAllDevicesV1();
        IQueryable<ThermostatV2> RetrieveAllDevicesV2();
    }
}
