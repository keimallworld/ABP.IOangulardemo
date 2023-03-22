using TiisShop.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TiisShop.Permissions;

public class TiisShopPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TiisShopPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TiisShopPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TiisShopResource>(name);
    }
}
