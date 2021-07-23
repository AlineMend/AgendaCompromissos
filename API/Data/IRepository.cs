using System.Collections.Generic;
using System.Threading.Tasks;
using API.Models;

namespace API.Data
{
    public interface IRepository 
    {
        void Add<T> (T entity) where T : class;
        void Update<T> (T entity) where T : class;
        void Delete<T> (T entity) where T : class; 
        Task<bool> SaveChangesAsync();

        Task<Compromissos[]> GetAllCompromissosAsync();
        Task<Compromissos> GetCompromissosAsyncById(int compromissosId);
    }
}