using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using warrantyRegisterAPI.Service.Contract;

namespace warrantyRegisterAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseController : ControllerBase
    {
        protected readonly IServiceFactory _serviceFactory;

        public BaseController(IServiceFactory serviceFactory)
        {
            _serviceFactory = serviceFactory;
        }

        [HttpGet("Test")]
        public string Test()
        {
            return $"{GetType().ToString().Split('.').Last().Replace("Controller", "")} API is live";
        }
    }
}