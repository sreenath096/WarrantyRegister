using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using warrantyRegisterAPI.DataContext;
using warrantyRegisterAPI.Repository.Contract;

namespace warrantyRegisterAPI.Repository
{
    public class RepositoryFactory : IRepositoryFactory
    {
        private readonly InMemoryDataContext _dataContext;

        public RepositoryFactory(InMemoryDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IWarrantyRegisterRepository WarrantyRegisterRepository
                => new WarrantyRegisterRepository(_dataContext);
    }
}