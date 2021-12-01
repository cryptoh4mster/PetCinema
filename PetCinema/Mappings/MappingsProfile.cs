using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using PetCinemaBLL.DTO;
using PetCinemaDAL.Entities;
using PetCinemaPL.ViewModels;

namespace PetCinemaPL.Mappings
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<CreateMovieViewModel, CreateMovieDTO>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image));
            CreateMap<CreateMovieDTO, CreateMovieViewModel>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image));
            CreateMap<CreateMovieDTO, Movie>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image));
            CreateMap<Movie, CreateMovieDTO>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image));
            CreateMap<IndexMovieViewModel, IndexMovieDTO>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));
            CreateMap<IndexMovieDTO, IndexMovieViewModel>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));
            CreateMap<IndexMovieDTO, Movie>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));
            CreateMap<Movie, IndexMovieDTO>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));
        }
    }
}
