using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using warrantyRegisterAPI.Models.Entities;
using warrantyRegisterAPI.Models.Request;

namespace warrantyRegisterAPI.Service.Contract
{
    public interface IWarrantyRegisterService
    {
        IEnumerable<WarrantyRegister> GetWarrantyRegisterList();
        WarrantyRegister GetWarrantyRegisterById(int id);
        void CreateWarrantyRegister(CreateWarrantyRegisterRequest request);
        void UpdateWarrantyRegister(int id, UpdateWarrantyRegisterRequest request);
        void DeleteWarrantyRegister(int id);
    }
}