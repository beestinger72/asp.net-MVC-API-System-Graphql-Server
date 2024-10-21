using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using WebApplication1.Data;

namespace WebApplication1.GraphQL
{
    public class Mutation
    {
        private readonly AppDbContext _context;

        public Mutation(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<bool> CreateEntity<TEntity>(TEntity entity) where TEntity : class
        {
            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateEntity<TEntity>(TEntity entity) where TEntity : class
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteEntity<TEntity>(int id) where TEntity : class
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);
            if (entity == null)
                return false;

            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        // Placeholder method, you can remove this if not needed
        public async Task<bool> PlaceholderMutation()
        {
            // Placeholder logic (returns true for example)
            return true;
        }
    }
}
