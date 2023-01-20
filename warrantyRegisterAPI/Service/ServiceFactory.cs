using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using warrantyRegisterAPI.Repository.Contract;
using warrantyRegisterAPI.Service.Contract;

namespace warrantyRegisterAPI.Service
{
    public class ServiceFactory : IServiceFactory
    {
        private readonly IRepositoryFactory _repositoryFactory;
        private readonly IMapper _mapper;

        public ServiceFactory(IRepositoryFactory repositoryFactory, IMapper mapper)
        {
            _repositoryFactory = repositoryFactory;
            _mapper = mapper;
        }

        public IWarrantyRegisterService WarrantyRegisterService
                => new WarrantyRegisterService(_repositoryFactory.WarrantyRegisterRepository, _mapper);
    }
}