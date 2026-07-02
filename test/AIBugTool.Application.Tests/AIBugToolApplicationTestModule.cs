using Volo.Abp.Modularity;

namespace AIBugTool;

[DependsOn(
    typeof(AIBugToolApplicationModule),
    typeof(AIBugToolDomainTestModule)
)]
public class AIBugToolApplicationTestModule : AbpModule
{

}
