using HotChocolate;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using WebApplication1.Data;

namespace WebApplication1.GraphQL
{
    public class MutationTypeExtensions : ObjectTypeExtension<Mutation>
    {
        private readonly AppDbContext _context;

        public MutationTypeExtensions(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        protected override void Configure(IObjectTypeDescriptor<Mutation> descriptor)
        {
            // Get all entity types from AppDbContext
            var entityTypes = _context.Model.GetEntityTypes()
                .Select(t => t.ClrType)
                .ToList();

            // Iterate over each entity type to create mutation fields
            foreach (var entityType in entityTypes)
            {
                // Generate method names (e.g., CreateEntity, UpdateEntity, DeleteEntity)
                var createMethodName = $"Create{entityType.Name}";
                var updateMethodName = $"Update{entityType.Name}";
                var deleteMethodName = $"Delete{entityType.Name}";

                // Find corresponding methods in Mutation class using reflection
                var createMethod = typeof(Mutation).GetMethod(createMethodName);
                var updateMethod = typeof(Mutation).GetMethod(updateMethodName);
                var deleteMethod = typeof(Mutation).GetMethod(deleteMethodName);

                if (createMethod != null)
                {
                    // Define Create mutation field
                    descriptor.Field(createMethodName.ToLower())
                        .Argument("entity", arg => arg.Type<NonNullType<ObjectType>>())
                        .Type<NonNullType<BooleanType>>()
                        .Resolve(async ctx =>
                        {
                            var entity = ctx.ArgumentValue<object>("entity");
                            var mutationInstance = Activator.CreateInstance(typeof(Mutation), _context);
                            var task = (Task<bool>)createMethod.Invoke(mutationInstance, new[] { entity });
                            return await task; // Await the task here to get the boolean result
                        });
                }

                if (updateMethod != null)
                {
                    // Define Update mutation field
                    descriptor.Field(updateMethodName.ToLower())
                        .Argument("entity", arg => arg.Type<NonNullType<ObjectType>>())
                        .Type<NonNullType<BooleanType>>()
                        .Resolve(async ctx =>
                        {
                            var entity = ctx.ArgumentValue<object>("entity");
                            var mutationInstance = Activator.CreateInstance(typeof(Mutation), _context);
                            var task = (Task<bool>)updateMethod.Invoke(mutationInstance, new[] { entity });
                            return await task; // Await the task here to get the boolean result
                        });
                }

                if (deleteMethod != null)
                {
                    // Define Delete mutation field
                    descriptor.Field(deleteMethodName.ToLower())
                        .Argument("id", arg => arg.Type<NonNullType<IntType>>())
                        .Type<NonNullType<BooleanType>>()
                        .Resolve(async ctx =>
                        {
                            var id = ctx.ArgumentValue<int>("id");
                            var mutationInstance = Activator.CreateInstance(typeof(Mutation), _context);
                            var task = (Task<bool>)deleteMethod.Invoke(mutationInstance, new object[] { id });
                            return await task; // Await the task here to get the boolean result
                        });
                }
            }
        }
    }
}
