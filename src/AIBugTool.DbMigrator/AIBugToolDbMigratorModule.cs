using AIBugTool.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AIBugTool.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AIBugToolEntityFrameworkCoreModule),
    typeof(AIBugToolApplicationContractsModule)
)]
public class AIBugToolDbMigratorModule : AbpModule
{
}
