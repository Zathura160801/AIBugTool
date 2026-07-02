using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AIBugTool.Data;
using Volo.Abp.DependencyInjection;

namespace AIBugTool.EntityFrameworkCore;

public class EntityFrameworkCoreAIBugToolDbSchemaMigrator
    : IAIBugToolDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAIBugToolDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AIBugToolDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AIBugToolDbContext>()
            .Database
            .MigrateAsync();
    }
}
