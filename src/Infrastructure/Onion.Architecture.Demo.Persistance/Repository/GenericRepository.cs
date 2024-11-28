
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Onion.architecture.Demo.Application.Interfaces.Repository;
using Onion.Architecture.Demo.Domain.Common;
using Onion.Architecture.Demo.Persistance.Context;

namespace Onion.Architecture.Demo.Persistance.Repository
{
    public  class GenericRepository : IGenericRepositoryAsync<T> where T: BaseEntity
    {
        public ApplicationDbContext DbContext { get; }
        public GenericRepository(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }


        public async Task<T> AddAsync(T entity)
        {
            await DbContext.Set<T>().AddAsync(entity);
            await DbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
           await DbContext.Set<T>().ExecuteDeleteAsync(entity);
           await DbContext.SaveChangesAsync();
            return entity;

        }

        public async Task<List<T>> GetAllAsync()
        {
          return  await DbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid Id)
        {
          return  await DbContext.Set<T>().FindAsync(Id);
        }

      

       
    }
}
