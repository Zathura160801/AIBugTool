using Xunit;

namespace AIBugTool.EntityFrameworkCore;

[CollectionDefinition(AIBugToolTestConsts.CollectionDefinitionName)]
public class AIBugToolEntityFrameworkCoreCollection : ICollectionFixture<AIBugToolEntityFrameworkCoreFixture>
{

}
