namespace queue.Services.Interfaces;

public interface IGenericService<T> where T : class
{
    Task<IEnumerable<T>> GetPagedAsync(int page = 1, int pageSize = 10);
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetByIdAsync(int id);
    Task<bool> RemoveAsync(int id);
    Task<T> UpdateAsync(T entity);
}