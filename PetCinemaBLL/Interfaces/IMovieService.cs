using PetCinemaBLL.DTO;
using PetCinemaDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PetCinemaBLL.Interfaces
{
    public interface IMovieService
    {
        Task<IEnumerable<IndexMovieDTO>> GetMovies();
        Task<IndexMovieDTO> GetMovieById(Guid id);
        Task DeleteMovieById(Guid id);
        Task<CreateMovieDTO> UpdateMovie(CreateMovieDTO movieDTO);
        Task<CreateMovieDTO> AddMovie(CreateMovieDTO movieDTO);
        Task<IEnumerable<IndexMovieDTO>> GetTopMoviesByRating();
        Task<IEnumerable<IndexMovieDTO>> GetMoviesBySearchString(string searchString);
    }
}
