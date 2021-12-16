using Microsoft.EntityFrameworkCore;
using PetCinemaDAL.EF;
using PetCinemaDAL.Entities;
using PetCinemaDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCinemaDAL.Repositories
{
    public class SerialRepository : GenericRepository<Serial>, ISerialRepository
    {
        public SerialRepository(PetCinemaContext _context) : base(_context)
        {

        }
        public async Task<IEnumerable<Serial>> GetTopSerialsByRating()
        {
            IEnumerable<Serial> serials = await _context.Serials.ToListAsync();
            var top10 = (from serial in serials
                         orderby serial.Rating
                         select serial).Take(10);
            return top10;
        }
    }
}
