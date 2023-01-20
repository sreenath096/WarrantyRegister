using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using warrantyRegisterAPI.Models.Request;
using warrantyRegisterAPI.Service.Contract;

namespace warrantyRegisterAPI.Controllers
{
    public class WarrantyRegisterController : BaseController
    {
        public WarrantyRegisterController(IServiceFactory serviceFactory)
            : base(serviceFactory)
        {
        }

        [HttpGet]
        public IActionResult GetWarrantyRegisterList()
        {
            var warrantyList = _serviceFactory.WarrantyRegisterService.GetWarrantyRegisterList();
            return Ok(warrantyList);
        }
        [HttpGet("{id}")]
        public IActionResult GetWarrantyRegisterById(int id)
        {
            var warranty = _serviceFactory.WarrantyRegisterService.GetWarrantyRegisterById(id);
            return Ok(warranty);
        }
        [HttpPost]
        public IActionResult CreateWarrantyRegister(CreateWarrantyRegisterRequest request)
        {
            _serviceFactory.WarrantyRegisterService.CreateWarrantyRegister(request);
            return Ok(new { message = "Warranty Registered Successfully" });
        }
        [HttpPut("{id}")]
        public IActionResult UpdateWarrantyRegister(int id, UpdateWarrantyRegisterRequest request)
        {
            _serviceFactory.WarrantyRegisterService.UpdateWarrantyRegister(id, request);
            return Ok(new { message = "Warranty Updated Successfully" });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteWarrantyRegister(int id)
        {
            _serviceFactory.WarrantyRegisterService.DeleteWarrantyRegister(id);
            return Ok(new { message = "Warranty Deleted Successfully" });
        }
    }
}