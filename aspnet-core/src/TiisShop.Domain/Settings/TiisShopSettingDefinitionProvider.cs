using Volo.Abp.Settings;

namespace TiisShop.Settings;

public class TiisShopSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TiisShopSettings.MySetting1));
    }
}
