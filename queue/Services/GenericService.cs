using Microsoft.EntityFrameworkCore;
using queue.Data;
using queue.Services.Interfaces;

namespace queue.Services;

public class GenericService<T>:IGenericService<T> where T : class
{
    private readonly AppDbContext _dbContext;
    private readonly DbSet<T> _dbSet;

    public GenericService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<T>();
    }
    public virtual async Task<T?> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public virtual async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync(); 
    }

    public async Task<bool> RemoveAsync(int id)
    {
        var entity = await _dbSet.FindAsync(id);
        if (entity is null) return false;
        _dbSet.Remove(entity);
        await _dbContext.SaveChangesAsync();
        return true;
    }

    public async Task<T> UpdateAsync(T entity)
    {
        _dbSet.Update(entity);
        await _dbContext.SaveChangesAsync();
        return entity;
    }
}