namespace queue.Services.Interfaces;

public interface IGenericService<T> where T : class
{
    Task<T?> GetByIdAsync(int id);
    Task<IEnumerable<T>> GetAllAsync();
    Task<bool> RemoveAsync(int id);
    Task<T> UpdateAsync(T entity);
}