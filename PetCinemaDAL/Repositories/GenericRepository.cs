using Microsoft.EntityFrameworkCore;
using PetCinemaDAL.EF;
using PetCinemaDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCinemaDAL.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly PetCinemaContext _context;
        private readonly DbSet<TEntity> _table;

        /*public GenericRepository()
        {
            _context = new PetCinemaContext();
            _table = _context.Set<TEntity>();
        }*/
        public GenericRepository(PetCinemaContext context)
        {
            _context = context;
            _table = _context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _table.ToListAsync();
        }

        public async Task<TEntity> GetById(object id)
        {
            return await _table.FindAsync(id);
        }

        public async Task<TEntity> Add(TEntity obj)
        {
            await _table.AddAsync(obj);
            await _context.SaveChangesAsync();
            return obj;
        }
        public async Task<TEntity> Update(TEntity obj)
        {
            //TODO: Проверить обновляются все поля или только измененные??
            _table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return obj;
        }

        public async Task Delete(object id)
        {
            TEntity entityExist = await _table.FindAsync(id);
            _table.Remove(entityExist);
            await _context.SaveChangesAsync();
        }
    }
}
