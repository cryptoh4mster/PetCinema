using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetCinemaBLL.DTO;
using PetCinemaBLL.Interfaces;
using PetCinemaPL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetCinemaPL.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SerialController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISerialService _serialService;
        public SerialController(ISerialService serialService, IMapper mapper)
        {
            _serialService = serialService;
            _mapper = mapper;
        }
        [HttpGet]
        [Route("getserials")]
        public async Task<ActionResult<IEnumerable<IndexSerialViewModel>>> GetSerials()
        {
            IEnumerable<IndexSerialDTO> serialDTOs = await _serialService.GetSerials();
            IEnumerable<IndexSerialViewModel> serialViewModels = _mapper.Map<IEnumerable<IndexSerialViewModel>>(serialDTOs);
            return Ok(serialViewModels);
        }
        [HttpPost]
        public async Task<ActionResult<CreateSerialViewModel>> AddSerial(CreateSerialViewModel serialViewModel)
        {
            CreateSerialDTO serialDTO = _mapper.Map<CreateSerialDTO>(serialViewModel);
            return Ok(await _serialService.AddSerial(serialDTO));
        }
        [HttpGet]
        [Route("bestrating")]
        public async Task<ActionResult<IEnumerable<IndexMovieViewModel>>> GetTopMoviesByRating()
        {
            IEnumerable<IndexSerialDTO> serialDTOs = await _serialService.GetSerials();
            IEnumerable<IndexSerialViewModel> serialViewModels = _mapper.Map<IEnumerable<IndexSerialViewModel>>(serialDTOs);
            return Ok(serialViewModels);
        }
    }
}
