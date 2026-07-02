using Volo.Abp.Modularity;

namespace AIBugTool;

/* Inherit from this class for your domain layer tests. */
public abstract class AIBugToolDomainTestBase<TStartupModule> : AIBugToolTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
