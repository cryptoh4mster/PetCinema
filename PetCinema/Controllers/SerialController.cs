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

        //TODO: Везде сделать проверку на ошибки и отправку разных статусных кодов

        [HttpGet]
        [Route("serials")]
        public async Task<ActionResult<IEnumerable<IndexSerialViewModel>>> GetSerials()
        {
            IEnumerable<IndexSerialDTO> serialDTOs = await _serialService.GetSerials();
            IEnumerable<IndexSerialViewModel> serialViewModels = _mapper.Map<IEnumerable<IndexSerialViewModel>>(serialDTOs);
            return Ok(serialViewModels);
        }

        [HttpGet]
        [Route("serials/{id}")]
        public async Task<ActionResult<IndexSerialDTO>> GetSerialById(Guid id)
        {
            IndexSerialDTO serialDTO = await _serialService.GetSerialById(id);
            IndexSerialViewModel serialViewModel = _mapper.Map<IndexSerialViewModel>(serialDTO);
            return Ok(serialViewModel);
        }

        [HttpPost]
        public async Task<ActionResult<CreateSerialViewModel>> AddSerial(CreateSerialViewModel serialViewModel)
        {
            CreateSerialDTO serialDTO = _mapper.Map<CreateSerialDTO>(serialViewModel);
            return Ok(await _serialService.AddSerial(serialDTO));
        }

        [HttpDelete]
        [Route("serials/{id}")]
        public async Task<ActionResult> DeleteSerialById(Guid id)
        {
            await _serialService.DeleteSerialById(id);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult<CreateSerialViewModel>> UpdateSerial(CreateSerialViewModel serialViewModel)
        {
            CreateSerialDTO serialDTO = _mapper.Map<CreateSerialDTO>(serialViewModel);
            return Ok(await _serialService.UpdateSerial(serialDTO));
        }

        [HttpGet]
        [Route("serials/top")]
        public async Task<ActionResult<IEnumerable<IndexMovieViewModel>>> GetTopSerialsByRating()
        {
            IEnumerable<IndexSerialDTO> serialDTOs = await _serialService.GetTopSerialsByRating();
            IEnumerable<IndexSerialViewModel> serialViewModels = _mapper.Map<IEnumerable<IndexSerialViewModel>>(serialDTOs);
            return Ok(serialViewModels);
        }
    }
}
