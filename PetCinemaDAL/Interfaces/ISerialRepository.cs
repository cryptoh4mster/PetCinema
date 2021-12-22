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
        Task<IEnumerable<Serial>> GetTopSerialsByRating();
        Task<IEnumerable<Serial>> GetSerialsBySearchString(string searchString);
    }
}
