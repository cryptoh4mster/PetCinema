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
    public class SerialRepository : ISerialRepository
    {
        private readonly PetCinemaContext _context;
        public SerialRepository(PetCinemaContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Serial>> GetSerials()
        {
            return await _context.Serials.ToListAsync();
        }
        public async Task<Serial> AddSerial(Serial serial)
        {
            await _context.Serials.AddAsync(serial);
            await _context.SaveChangesAsync();
            return serial;
        }
    }
}
