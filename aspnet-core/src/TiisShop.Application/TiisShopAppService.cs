using System;
using System.Collections.Generic;
using System.Text;
using TiisShop.Localization;
using Volo.Abp.Application.Services;

namespace TiisShop;

/* Inherit your application services from this class.
 */
public abstract class TiisShopAppService : ApplicationService
{
    protected TiisShopAppService()
    {
        LocalizationResource = typeof(TiisShopResource);
    }
}
