using TiisShop.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TiisShop.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TiisShopController : AbpControllerBase
{
    protected TiisShopController()
    {
        LocalizationResource = typeof(TiisShopResource);
    }
}
