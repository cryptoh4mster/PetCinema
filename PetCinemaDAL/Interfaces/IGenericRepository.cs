﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCinemaDAL.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(object id);
        Task<TEntity> Add(TEntity obj);
        Task Delete(object id);
        Task<TEntity> Update(TEntity obj);

    }
}
