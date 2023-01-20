using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace warrantyRegisterAPI.Repository.Contract
{
    public interface IRepositoryFactory
    {
        IWarrantyRegisterRepository WarrantyRegisterRepository { get; }
    }
}