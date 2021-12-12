using AspNetCoreIdentityPL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreIdentityBLL.DTO;
using AutoMapper;
using AspNetCoreIdentityDAL.Entities;

namespace AspNetCoreIdentityPL.Mappings
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<CreateUserViewModel, CreateUserDTO>()
                    .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                    .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password))
                    .ForMember(dest => dest.PasswordConfirm, opt => opt.MapFrom(src => src.PasswordConfirm));
            CreateMap<CreateUserDTO, User>()
                    .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email));
        }     
    }
}
