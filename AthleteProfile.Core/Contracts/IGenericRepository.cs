using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthleteProfile.Core.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<TResult> GetAsync<TResult>();
        Task<TResult> GetAsync<TResult>(int? id);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}
