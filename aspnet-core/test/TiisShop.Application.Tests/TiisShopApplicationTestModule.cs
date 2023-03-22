using Volo.Abp.Modularity;

namespace TiisShop;

[DependsOn(
    typeof(TiisShopApplicationModule),
    typeof(TiisShopDomainTestModule)
    )]
public class TiisShopApplicationTestModule : AbpModule
{

}
