using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using VersionDemo.Models;
using VersionDemo.Services;

namespace VersionDemo.Controllers.v1
{

    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]

    public class DevicesController : ODataController
    {
        private readonly IDeviceService _deviceService;

        public DevicesController(IDeviceService deviceService)
        {
            _deviceService = deviceService;
        }

        [HttpGet]
        [EnableQuery]
        public ActionResult<IQueryable<ThermostatV1>> Get() {
            var devices = _deviceService.RetrieveAllDevicesV1();
            return Ok(devices);
        }
    }
}
namespace VersionDemo.Controllers.v2
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class DevicesController : ODataController
    {
        private readonly IDeviceService _deviceServicee;

        public DevicesController(IDeviceService deviceService)
        {
            _deviceServicee = deviceService;
        }

        [HttpGet]
        [EnableQuery]

        public ActionResult<IQueryable<ThermostatV2>> Get()
        {
            var devices = _deviceServicee.RetrieveAllDevicesV2();
            return Ok(devices);
        }
    }

}
