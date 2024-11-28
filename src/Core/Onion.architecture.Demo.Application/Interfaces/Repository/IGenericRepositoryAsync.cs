using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onion.Architecture.Demo.Domain.Common;

namespace Onion.architecture.Demo.Application.Interfaces.Repository
{
    public interface IGenericRepositoryAsync<T>  where T : BaseEntity
    {
        Task<T> AddAsync(T entity);
        Task DeleteAsync(T entity); 
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid Id);
      

    }
}
