/*using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebApplication1.Data;
using WebApplication1.Models;

public class Query
{
    [UseDbContext(typeof(AppDbContext))]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Audit> GetAudits([ScopedService] AppDbContext dbContext)
    {
        return dbContext.Audits;
    }

    [UseDbContext(typeof(AppDbContext))]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Company> GetCompanies([ScopedService] AppDbContext dbContext)
    {
        return dbContext.Companies;
    }
} works*/

using HotChocolate;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;
using WebApplication1.Data;

public class Query : ObjectType
{
    protected override void Configure(IObjectTypeDescriptor descriptor)
    {
        var dbContextType = typeof(AppDbContext);

        foreach (var property in dbContextType.GetProperties().Where(p => p.PropertyType.IsGenericType && p.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>)))
        {
            var entityType = property.PropertyType.GetGenericArguments()[0];
            var entityName = entityType.Name;
            var dbSetProperty = property;

            // Define a method to dynamically add a field
            MethodInfo method = typeof(Query).GetMethod(nameof(AddField)).MakeGenericMethod(entityType);
            method.Invoke(this, new object[] { descriptor, entityName });
        }
    }

    public void AddField<TEntity>(IObjectTypeDescriptor descriptor, string entityName) where TEntity : class
    {
        descriptor.Field(entityName.ToLower())
            .ResolveWith<Resolvers>(resolver => resolver.GetEntities<TEntity>(default!))
            .UseDbContext<AppDbContext>()
            .UseFiltering()
            .UseSorting();
    }

    private class Resolvers
    {
        public IQueryable<TEntity> GetEntities<TEntity>([ScopedService] AppDbContext dbContext) where TEntity : class
        {
            return dbContext.Set<TEntity>();
        }
    }
}
