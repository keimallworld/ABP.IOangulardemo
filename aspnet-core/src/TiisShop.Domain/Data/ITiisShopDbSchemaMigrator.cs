using System.Threading.Tasks;

namespace TiisShop.Data;

public interface ITiisShopDbSchemaMigrator
{
    Task MigrateAsync();
}
