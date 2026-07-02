using AIBugTool.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AIBugTool.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AIBugToolController : AbpControllerBase
{
    protected AIBugToolController()
    {
        LocalizationResource = typeof(AIBugToolResource);
    }
}
