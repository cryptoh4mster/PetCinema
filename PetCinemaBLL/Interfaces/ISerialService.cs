using PetCinemaBLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCinemaBLL.Interfaces
{
    public interface ISerialService
    {
        Task<IEnumerable<IndexSerialDTO>> GetSerials();
        Task<CreateSerialDTO> AddSerial(CreateSerialDTO serialDTO);
        Task<IEnumerable<IndexSerialDTO>> GetTopSerialsByRating();
    }
}
