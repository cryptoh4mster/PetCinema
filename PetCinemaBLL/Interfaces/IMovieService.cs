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
        Task<CreateMovieDTO> AddMovie(CreateMovieDTO movieDTO);
    }
}
