using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using warrantyRegisterAPI.Models.Entities;
using warrantyRegisterAPI.Models.Request;

namespace warrantyRegisterAPI.Common.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateWarrantyRegisterRequest, WarrantyRegister>();
            CreateMap<UpdateWarrantyRegisterRequest, WarrantyRegister>();
        }
    }
}