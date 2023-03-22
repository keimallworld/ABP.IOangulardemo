using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace TiisShop;

[Dependency(ReplaceServices = true)]
public class TiisShopBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TiisShop";
}
