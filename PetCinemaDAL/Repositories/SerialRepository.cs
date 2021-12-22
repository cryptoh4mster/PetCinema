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
                         orderby serial.Rating descending
                         select serial).Take(10);
            return top10;
        }

        public async Task<IEnumerable<Serial>> GetSerialsBySearchString(string searchString)
        {
            IEnumerable<Serial> serials = await _context.Serials.ToListAsync();
            serials = serials.Where(serial => serial.Name.Contains(searchString));
            return serials;
        }
    }
}
