using AIBugTool.Samples;
using Xunit;

namespace AIBugTool.EntityFrameworkCore.Applications;

[Collection(AIBugToolTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AIBugToolEntityFrameworkCoreTestModule>
{

}
