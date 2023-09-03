using AthleteProfile.Core.Contracts;
using AthleteProfile.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthleteProfile.Core.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AthleteProfileDbContext _context;

        public GenericRepository(AthleteProfileDbContext context)
        {
            this._context = context;
        }
        public Task DeleteAsync(int id)
        {
            
        }

        public async Task<TResult> GetAsync<TResult>()
        {
        }

        public async Task<TResult> GetAsync<TResult>(int? id)
        {
            var result = _context.Set<T>().FindAsync(id);

            if (result is null)
            {
                return null;
            }
            
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
