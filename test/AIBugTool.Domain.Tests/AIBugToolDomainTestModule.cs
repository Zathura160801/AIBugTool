using Volo.Abp.Modularity;

namespace AIBugTool;

[DependsOn(
    typeof(AIBugToolDomainModule),
    typeof(AIBugToolTestBaseModule)
)]
public class AIBugToolDomainTestModule : AbpModule
{

}
