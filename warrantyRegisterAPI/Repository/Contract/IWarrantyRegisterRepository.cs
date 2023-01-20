using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using warrantyRegisterAPI.Models.Entities;

namespace warrantyRegisterAPI.Repository.Contract
{
    public interface IWarrantyRegisterRepository
    {
        IEnumerable<WarrantyRegister> GetWarrantyRegisterList();
        WarrantyRegister GetWarrantyRegisterById(int id);
        void CreateWarrantyRegister(WarrantyRegister model);
        void UpdateWarrantyRegister(WarrantyRegister model);
        void DeleteWarrantyRegister(int id);
    }
}