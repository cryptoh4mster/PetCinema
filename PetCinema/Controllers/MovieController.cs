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

        //TODO: Везде сделать проверку на ошибки и отправку разных статусных кодов
        [HttpGet]
        [Route("movies")]
        public async Task<ActionResult<IEnumerable<IndexMovieViewModel>>> GetMovies()
        {
            IEnumerable<IndexMovieDTO> movieDTOs = await _movieService.GetMovies();
            IEnumerable<IndexMovieViewModel> movieViewModels = _mapper.Map<IEnumerable<IndexMovieViewModel>>(movieDTOs);
            return Ok(movieViewModels);  
        }

        [HttpGet]
        [Route("movies/{id}")]
        public async Task<ActionResult<IndexMovieDTO>> GetMovieById(Guid id)
        {
            try
            {
                IndexMovieDTO movieDTO = await _movieService.GetMovieById(id);
                IndexMovieViewModel movieViewModel = _mapper.Map<IndexMovieViewModel>(movieDTO);
                return Ok(movieViewModel);
            }
            catch 
            {
                return NotFound("Фильма с таким id не существует");
            }
        }

        [HttpPost]
        public async Task<ActionResult<CreateMovieViewModel>> AddMovie(CreateMovieViewModel movieViewModel)
        {
            CreateMovieDTO movieDTO = _mapper.Map<CreateMovieDTO>(movieViewModel);
            return Ok(await _movieService.AddMovie(movieDTO));
        }

        [HttpDelete]
        [Route("movies/{id}")]
        public async Task<ActionResult> DeleteMovieById(Guid id)
        {
            try
            {
                await _movieService.DeleteMovieById(id);
                return Ok();
            }
            catch
            {
                return NotFound("Фильма с таким id не существует");
            }
        }

        [HttpPut]
        public async Task<ActionResult<CreateMovieViewModel>> UpdateMovie(CreateMovieViewModel movieViewModel)
        {
            CreateMovieDTO movieDTO = _mapper.Map<CreateMovieDTO>(movieViewModel);
            try
            {
                return Ok(await _movieService.UpdateMovie(movieDTO));
            }
            catch
            {
                return NotFound("Сущность не найдена");
            }
        }

        [HttpGet]
        [Route("movies/top")]
        public async Task<ActionResult<IEnumerable<IndexMovieViewModel>>> GetTopMoviesByRating()
        {
            IEnumerable<IndexMovieDTO> movieDTOs = await _movieService.GetTopMoviesByRating();
            IEnumerable<IndexMovieViewModel> movieViewModels = _mapper.Map<IEnumerable<IndexMovieViewModel>>(movieDTOs);
            return Ok(movieViewModels);
        }

        //Рут сделан неправильно
        [HttpGet]
        [Route("movies/search={searchString}")]
        public async Task<ActionResult<IEnumerable<IndexMovieViewModel>>> GetMoviesBySearchString(string searchString)
        {
            IEnumerable<IndexMovieDTO> movieDTOs = await _movieService.GetMoviesBySearchString(searchString);
            IEnumerable<IndexMovieViewModel> movieViewModels = _mapper.Map<IEnumerable<IndexMovieViewModel>>(movieDTOs);
            return Ok(movieViewModels);
        }
    }
}
