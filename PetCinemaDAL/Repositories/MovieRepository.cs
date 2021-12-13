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
    public class MovieRepository : IMovieRepository
    {
        private readonly PetCinemaContext _context;
        public MovieRepository(PetCinemaContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _context.Movies.ToListAsync();
        }
        public async Task<Movie> AddMovie(Movie movie)
        {
            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();
            return movie;
        }

        public async Task<IEnumerable<Movie>> GetTopMoviesByRating()
        {
            IEnumerable<Movie> movies = await _context.Movies.ToListAsync();
            var top10 = (from movie in movies
                         orderby movie.Rating
                         select movie).Take(10);
            return top10;
        }
    }
}
