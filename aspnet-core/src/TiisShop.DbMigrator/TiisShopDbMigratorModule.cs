using TiisShop.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace TiisShop.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TiisShopEntityFrameworkCoreModule),
    typeof(TiisShopApplicationContractsModule)
    )]
public class TiisShopDbMigratorModule : AbpModule
{

}
