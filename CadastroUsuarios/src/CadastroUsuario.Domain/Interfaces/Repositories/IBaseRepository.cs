namespace CadastroUsuario.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity>
        where TEntity : class
    {
        Task CreateAsync(TEntity obj);
        Task UpdateAsync(TEntity obj);
        Task DeleteAsync(TEntity obj);

        Task<List<TEntity>> Get();
        Task<TEntity> GetById(int id);
    }
}
