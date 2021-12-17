using AutoMapper;
using PetCinemaBLL.DTO;
using PetCinemaBLL.Interfaces;
using PetCinemaDAL.Entities;
using PetCinemaDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PetCinemaBLL.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMapper _mapper;
        public MovieService(IMovieRepository movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<IndexMovieDTO>> GetMovies()
        {
            IEnumerable<Movie> Movies = await _movieRepository.GetAll();
            IEnumerable<IndexMovieDTO> MovieDTOs = _mapper.Map<IEnumerable<IndexMovieDTO>>(Movies);
            return MovieDTOs;
        }

        public async Task<IndexMovieDTO> GetMovieById(int id)
        {
            Movie movie = await _movieRepository.GetById(id);
            IndexMovieDTO movieDTO = _mapper.Map<IndexMovieDTO>(movie);
            return movieDTO;
        }

        public async Task DeleteMovieById(int id)
        {
            await _movieRepository.Delete(id);
        }

        public async Task<CreateMovieDTO> AddMovie(CreateMovieDTO movieDTO) 
        {
            Movie movie = _mapper.Map<Movie>(movieDTO);  
            Movie movieForMapping = await _movieRepository.Add(movie);
            return _mapper.Map<CreateMovieDTO>(movieForMapping);
        }

        public async Task<CreateMovieDTO> UpdateMovie(CreateMovieDTO movieDTO)
        {
            Movie movie = _mapper.Map<Movie>(movieDTO);
            Movie movieForMapping = await _movieRepository.Update(movie);
            return _mapper.Map<CreateMovieDTO>(movieForMapping);
        }

        public async Task<IEnumerable<IndexMovieDTO>> GetTopMoviesByRating()
        {
            IEnumerable<Movie> Movies = await _movieRepository.GetTopMoviesByRating();
            IEnumerable<IndexMovieDTO> MovieDTOs = _mapper.Map<IEnumerable<IndexMovieDTO>>(Movies);
            return MovieDTOs;
        }
    }
}
