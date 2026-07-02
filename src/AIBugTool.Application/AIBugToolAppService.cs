using AIBugTool.Localization;
using Volo.Abp.Application.Services;

namespace AIBugTool;

/* Inherit your application services from this class.
 */
public abstract class AIBugToolAppService : ApplicationService
{
    protected AIBugToolAppService()
    {
        LocalizationResource = typeof(AIBugToolResource);
    }
}
