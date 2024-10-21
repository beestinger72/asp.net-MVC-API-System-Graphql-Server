
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly AppDbContext _context;

    public Repository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _context.Set<TEntity>().ToListAsync();
    }

    public async Task<TEntity> GetByIdAsync(object id)
    {
        // Handle potential composite key types (adjust as needed)
        if (id is not int && id is not long && id is not string)
        {
            throw new ArgumentException("Unsupported type for primary key");
        }
        return await _context.Set<TEntity>().FindAsync(id);
    }

    public async Task<TEntity> InsertAsync(TEntity entity)
    {
        _context.Set<TEntity>().Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task UpdateAsync(TEntity entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(object id)
    {
        TEntity entityToDelete = await _context.Set<TEntity>().FindAsync(id);
        if (entityToDelete != null)
        {
            _context.Set<TEntity>().Remove(entityToDelete);
            await _context.SaveChangesAsync();
        }
    }
}