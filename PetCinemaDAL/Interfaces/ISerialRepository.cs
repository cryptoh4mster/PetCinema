using PetCinemaDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCinemaDAL.Interfaces
{
    public interface ISerialRepository : IGenericRepository<Serial>
    {
        /*Task<IEnumerable<Serial>> GetSerials();
        Task<Serial> AddSerial(Serial serial);*/
        Task<IEnumerable<Serial>> GetTopSerialsByRating();
    }
}
