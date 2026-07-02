using Volo.Abp.Settings;

namespace AIBugTool.Settings;

public class AIBugToolSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AIBugToolSettings.MySetting1));
    }
}
