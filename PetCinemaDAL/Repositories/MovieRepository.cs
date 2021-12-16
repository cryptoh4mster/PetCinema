using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetCinemaDAL.EF;
using PetCinemaDAL.Entities;
using PetCinemaDAL.Interfaces;
using System.Linq;

namespace PetCinemaDAL.Repositories
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        public MovieRepository(PetCinemaContext _context) : base(_context)
        {

        }
        public async Task<IEnumerable<Movie>> GetTopMoviesByRating()
        {
            IEnumerable<Movie> movies = await _context.Movies.ToListAsync();
            var top10 = (from movie in movies
                         orderby movie.Rating descending
                         select movie).Take(10);
            return top10;
        }
    }
}
