using CadastroUsuario.Domain.Interfaces.Repositories;
using CadastroUsuarios.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CadastroUsuario.InfraData.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : class
    {
        private readonly SqlServerContext _context;

        public BaseRepository(SqlServerContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Added;
            await _context.SaveChangesAsync();
        }
        
        public async Task UpdateAsync(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<List<TEntity>> Get()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }
    }
}
