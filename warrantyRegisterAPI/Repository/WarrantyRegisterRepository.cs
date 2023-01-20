using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using warrantyRegisterAPI.DataContext;
using warrantyRegisterAPI.Models.Entities;
using warrantyRegisterAPI.Repository.Contract;

namespace warrantyRegisterAPI.Repository
{
    public class WarrantyRegisterRepository : BaseRepository, IWarrantyRegisterRepository
    {
        public WarrantyRegisterRepository(InMemoryDataContext dataContext)
            : base(dataContext)
        {
        }

        public void CreateWarrantyRegister(WarrantyRegister model)
        {
            _dataContext.WarrantyRegisters.Add(model);
            _dataContext.SaveChanges();
        }

        public void DeleteWarrantyRegister(int id)
        {
            var model = GetWarrantyRegisterById(id);
            if (model != null)
            {
                _dataContext.WarrantyRegisters.Remove(model);
                _dataContext.SaveChanges();
            }
        }

        public WarrantyRegister GetWarrantyRegisterById(int id)
        {
            var model = _dataContext.WarrantyRegisters.Find(id);
            if (model == null)
                throw new KeyNotFoundException("Warranty registered not found");
            return model;
        }

        public IEnumerable<WarrantyRegister> GetWarrantyRegisterList()
        {
            return _dataContext.WarrantyRegisters;
        }

        public void UpdateWarrantyRegister(WarrantyRegister model)
        {
            _dataContext.WarrantyRegisters.Update(model);
            _dataContext.SaveChanges();
        }
    }
}