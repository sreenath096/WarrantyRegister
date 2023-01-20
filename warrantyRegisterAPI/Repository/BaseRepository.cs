using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using warrantyRegisterAPI.DataContext;

namespace warrantyRegisterAPI.Repository
{
    public class BaseRepository
    {
        protected readonly InMemoryDataContext _dataContext;

        public BaseRepository(InMemoryDataContext dataContext)
        {
            _dataContext = dataContext;
        }
    }
}