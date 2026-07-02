using Volo.Abp.Modularity;

namespace AIBugTool;

public abstract class AIBugToolApplicationTestBase<TStartupModule> : AIBugToolTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
