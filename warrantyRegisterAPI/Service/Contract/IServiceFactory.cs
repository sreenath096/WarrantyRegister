using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace warrantyRegisterAPI.Service.Contract
{
    public interface IServiceFactory
    {
        IWarrantyRegisterService WarrantyRegisterService { get; }
    }
}