using TiisShop.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace TiisShop;

[DependsOn(
    typeof(TiisShopEntityFrameworkCoreTestModule)
    )]
public class TiisShopDomainTestModule : AbpModule
{

}
