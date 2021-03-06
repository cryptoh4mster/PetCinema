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
                    .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image))
                    .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
                    .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre))
                    .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => src.Rating));
            CreateMap<CreateMovieDTO, CreateMovieViewModel>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image))
                    .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
                    .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre))
                    .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => src.Rating));
            CreateMap<CreateMovieDTO, Movie>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image))
                    .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
                    .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre))
                    .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => src.Rating));
            CreateMap<Movie, CreateMovieDTO>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image))
                    .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
                    .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre))
                    .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => src.Rating));
            CreateMap<IndexMovieViewModel, IndexMovieDTO>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image))
                    .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
                    .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre))
                    .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => src.Rating));
            CreateMap<IndexMovieDTO, IndexMovieViewModel>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image))
                    .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
                    .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre))
                    .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => src.Rating));
            CreateMap<IndexMovieDTO, Movie>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image))
                    .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
                    .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre))
                    .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => src.Rating));
            CreateMap<Movie, IndexMovieDTO>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image))
                    .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
                    .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre))
                    .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => src.Rating));
            CreateMap<CreateSerialViewModel, CreateSerialDTO>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image))
                    .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
                    .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre))
                    .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => src.Rating))
                    .ForMember(dest => dest.SeasonsAmount, opt => opt.MapFrom(src => src.SeasonsAmount))
                    .ForMember(dest => dest.SeriesAmount, opt => opt.MapFrom(src => src.SeriesAmount));
            CreateMap<CreateSerialDTO, CreateSerialViewModel>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image))
                    .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
                    .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre))
                    .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => src.Rating))
                    .ForMember(dest => dest.SeasonsAmount, opt => opt.MapFrom(src => src.SeasonsAmount))
                    .ForMember(dest => dest.SeriesAmount, opt => opt.MapFrom(src => src.SeriesAmount));
            CreateMap<CreateSerialDTO, Serial>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image))
                    .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
                    .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre))
                    .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => src.Rating))
                    .ForMember(dest => dest.SeasonsAmount, opt => opt.MapFrom(src => src.SeasonsAmount))
                    .ForMember(dest => dest.SeriesAmount, opt => opt.MapFrom(src => src.SeriesAmount));
            CreateMap<Serial, CreateSerialDTO>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image))
                    .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
                    .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre))
                    .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => src.Rating))
                    .ForMember(dest => dest.SeasonsAmount, opt => opt.MapFrom(src => src.SeasonsAmount))
                    .ForMember(dest => dest.SeriesAmount, opt => opt.MapFrom(src => src.SeriesAmount));
            CreateMap<IndexSerialDTO, IndexSerialViewModel>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image))
                    .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
                    .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre))
                    .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => src.Rating))
                    .ForMember(dest => dest.SeasonsAmount, opt => opt.MapFrom(src => src.SeasonsAmount))
                    .ForMember(dest => dest.SeriesAmount, opt => opt.MapFrom(src => src.SeriesAmount));
            CreateMap<IndexSerialViewModel, IndexSerialDTO>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image))
                    .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
                    .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre))
                    .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => src.Rating))
                    .ForMember(dest => dest.SeasonsAmount, opt => opt.MapFrom(src => src.SeasonsAmount))
                    .ForMember(dest => dest.SeriesAmount, opt => opt.MapFrom(src => src.SeriesAmount));
            CreateMap<IndexSerialDTO, Serial>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image))
                    .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
                    .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre))
                    .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => src.Rating))
                    .ForMember(dest => dest.SeasonsAmount, opt => opt.MapFrom(src => src.SeasonsAmount))
                    .ForMember(dest => dest.SeriesAmount, opt => opt.MapFrom(src => src.SeriesAmount));
            CreateMap<Serial, IndexSerialDTO>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image))
                    .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
                    .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre))
                    .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => src.Rating))
                    .ForMember(dest => dest.SeasonsAmount, opt => opt.MapFrom(src => src.SeasonsAmount))
                    .ForMember(dest => dest.SeriesAmount, opt => opt.MapFrom(src => src.SeriesAmount));
        }
    }
}
