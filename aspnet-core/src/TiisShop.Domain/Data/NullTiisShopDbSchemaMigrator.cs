using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TiisShop.Data;

/* This is used if database provider does't define
 * ITiisShopDbSchemaMigrator implementation.
 */
public class NullTiisShopDbSchemaMigrator : ITiisShopDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
