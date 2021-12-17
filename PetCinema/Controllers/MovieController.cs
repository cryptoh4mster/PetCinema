using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PetCinemaBLL.DTO;
using PetCinemaBLL.Interfaces;
using PetCinemaDAL.Entities;
using PetCinemaPL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetCinema.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService, IMapper mapper)
        {
            _movieService = movieService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("getmovies")]
        public async Task<ActionResult<IEnumerable<IndexMovieViewModel>>> GetMovies()
        {
            IEnumerable<IndexMovieDTO> movieDTOs = await _movieService.GetMovies();
            IEnumerable<IndexMovieViewModel> movieViewModels = _mapper.Map<IEnumerable<IndexMovieViewModel>>(movieDTOs);
            return Ok(movieViewModels);
        }

        [HttpPost]
        public async Task<ActionResult<CreateMovieViewModel>> AddMovie(CreateMovieViewModel movieViewModel)
        {
            CreateMovieDTO movieDTO = _mapper.Map<CreateMovieDTO>(movieViewModel);
            return Ok(await _movieService.AddMovie(movieDTO));
        }

        [HttpGet]
        [Route("bestrating")]
        public async Task<ActionResult<IEnumerable<IndexMovieViewModel>>> GetTopMoviesByRating()
        {
            IEnumerable<IndexMovieDTO> movieDTOs = await _movieService.GetTopMoviesByRating();
            IEnumerable<IndexMovieViewModel> movieViewModels = _mapper.Map<IEnumerable<IndexMovieViewModel>>(movieDTOs);
            return Ok(movieViewModels);
        }
    }
}
