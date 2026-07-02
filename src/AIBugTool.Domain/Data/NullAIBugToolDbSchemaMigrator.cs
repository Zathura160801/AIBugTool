using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AIBugTool.Data;

/* This is used if database provider does't define
 * IAIBugToolDbSchemaMigrator implementation.
 */
public class NullAIBugToolDbSchemaMigrator : IAIBugToolDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
