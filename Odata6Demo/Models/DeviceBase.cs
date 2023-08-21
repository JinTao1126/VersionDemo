namespace VersionDemo.Models
{
    public abstract class DeviceBase
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = "thermostat";
    }
}
