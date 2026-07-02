using System.Threading.Tasks;

namespace AIBugTool.Data;

public interface IAIBugToolDbSchemaMigrator
{
    Task MigrateAsync();
}
