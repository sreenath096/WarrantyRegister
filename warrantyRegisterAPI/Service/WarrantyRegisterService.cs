using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using warrantyRegisterAPI.Models.Entities;
using warrantyRegisterAPI.Models.Request;
using warrantyRegisterAPI.Repository.Contract;
using warrantyRegisterAPI.Service.Contract;

namespace warrantyRegisterAPI.Service
{
    public class WarrantyRegisterService : IWarrantyRegisterService
    {
        private readonly IWarrantyRegisterRepository _repository;
        private readonly IMapper _mapper;

        public WarrantyRegisterService(IWarrantyRegisterRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void CreateWarrantyRegister(CreateWarrantyRegisterRequest request)
        {
            var model = _mapper.Map<WarrantyRegister>(request);
            _repository.CreateWarrantyRegister(model);
        }

        public void DeleteWarrantyRegister(int id)
        {
            _repository.DeleteWarrantyRegister(id);
        }

        public WarrantyRegister GetWarrantyRegisterById(int id)
        {
            return _repository.GetWarrantyRegisterById(id);
        }

        public IEnumerable<WarrantyRegister> GetWarrantyRegisterList()
        {
            return _repository.GetWarrantyRegisterList();
        }

        public void UpdateWarrantyRegister(int id, UpdateWarrantyRegisterRequest request)
        {
            var model = _repository.GetWarrantyRegisterById(id);
            _mapper.Map(request, model);
            _repository.UpdateWarrantyRegister(model);
        }
    }
}