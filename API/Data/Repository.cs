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

        public async Task<Compromissos> GetCompromissosAsyncById(int compromissosId, bool includeTarefa)
        {
             IQueryable<Compromissos> query = _context.Compromissos;

            if (includeTarefa)
            {
                query = query.Include(a => a.Tarefa);
            }

            query = query.AsNoTracking()
                         .OrderBy(compromissos => compromissos.Id)
                         .Where(compromissos => compromissos.Id == compromissosId);

            return await query.FirstOrDefaultAsync();
        }
    }
}