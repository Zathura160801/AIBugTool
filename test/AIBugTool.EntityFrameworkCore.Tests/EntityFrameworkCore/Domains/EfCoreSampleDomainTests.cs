using AIBugTool.Samples;
using Xunit;

namespace AIBugTool.EntityFrameworkCore.Domains;

[Collection(AIBugToolTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AIBugToolEntityFrameworkCoreTestModule>
{

}
