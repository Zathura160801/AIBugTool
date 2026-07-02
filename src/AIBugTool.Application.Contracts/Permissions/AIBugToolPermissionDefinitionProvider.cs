using AIBugTool.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace AIBugTool.Permissions;

public class AIBugToolPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AIBugToolPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(AIBugToolPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AIBugToolResource>(name);
    }
}
