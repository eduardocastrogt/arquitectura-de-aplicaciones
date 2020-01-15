using System;
using AutoMapper;
using Empresa.Ecommerce.Dominio.Entity;
using Empresa.Ecommerce.Application.DTO;

namespace Empresa.Ecommerce.Transversal.Mapper
{
    public class MappingsProfile: Profile
    {
        public MappingsProfile()
        {
            CreateMap<Customers, CustomersDTO>().ReverseMap();
            CreateMap<Customers, CustomersDTO>().ReverseMap()
                .ForMember(destino => destino.CustomerId, 
                    source => source.MapFrom(src => src.CustomerId));
        }
    }
}
