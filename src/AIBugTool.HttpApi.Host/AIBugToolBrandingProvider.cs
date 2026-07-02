using Microsoft.Extensions.Localization;
using AIBugTool.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AIBugTool;

[Dependency(ReplaceServices = true)]
public class AIBugToolBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<AIBugToolResource> _localizer;

    public AIBugToolBrandingProvider(IStringLocalizer<AIBugToolResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
