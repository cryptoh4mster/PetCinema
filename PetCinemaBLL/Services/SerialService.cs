using AutoMapper;
using PetCinemaBLL.DTO;
using PetCinemaBLL.Interfaces;
using PetCinemaDAL.Entities;
using PetCinemaDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCinemaBLL.Services
{
    public class SerialService : ISerialService
    {
        private readonly ISerialRepository _serialRepository;
        private readonly IMapper _mapper;
        public SerialService(ISerialRepository serialRepository, IMapper mapper)
        {
            _serialRepository = serialRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<IndexSerialDTO>> GetSerials()
        {
            IEnumerable<Serial> Serials = await _serialRepository.GetAll();
            IEnumerable<IndexSerialDTO> SerialDTOs = _mapper.Map<IEnumerable<IndexSerialDTO>>(Serials);
            return SerialDTOs;
        }

        public async Task<CreateSerialDTO> AddSerial(CreateSerialDTO serialDTO)
        {
            Serial serial = _mapper.Map<Serial>(serialDTO);
            Serial serialForMapping = await _serialRepository.Add(serial);
            return _mapper.Map<CreateSerialDTO>(serialForMapping);
        }
        public async Task<IndexSerialDTO> GetSerialById(Guid id)
        {
            Serial serial = await _serialRepository.GetById(id);
            IndexSerialDTO serialDTO = _mapper.Map<IndexSerialDTO>(serial);
            return serialDTO;
        }

        public async Task DeleteSerialById(Guid id)
        {
            await _serialRepository.Delete(id);
        }
        public async Task<CreateSerialDTO> UpdateSerial(CreateSerialDTO serialDTO)
        {
            Serial serial = _mapper.Map<Serial>(serialDTO);
            Serial serialForMapping = await _serialRepository.Update(serial);
            return _mapper.Map<CreateSerialDTO>(serialForMapping);
        }
        public async Task<IEnumerable<IndexSerialDTO>> GetTopSerialsByRating()
        {
            IEnumerable<Serial> Serials = await _serialRepository.GetTopSerialsByRating();
            IEnumerable<IndexSerialDTO> SerialDTOs = _mapper.Map<IEnumerable<IndexSerialDTO>>(Serials);
            return SerialDTOs;
        }
    }
}
