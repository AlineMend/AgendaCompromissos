using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Data
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
             _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
             _context.Remove(entity);
        }
         public async Task<bool> SaveChangesAsync()
        {
             return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<Compromissos> GetCompromissosAsyncById(int compromissosId)
        {
             IQueryable<Compromissos> query = _context.Compromissos;
            query = query.AsNoTracking()
                         .OrderBy(compromissos => compromissos.Id)
                         .Where(compromissos => compromissos.Id == compromissosId);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Compromissos[]> GetAllCompromissosAsync()
        {
            IQueryable<Compromissos> query = _context.Compromissos;
            query = query.AsNoTracking()
                         .OrderBy(c => c.Id);

            return await query.ToArrayAsync();
        }
    }
}