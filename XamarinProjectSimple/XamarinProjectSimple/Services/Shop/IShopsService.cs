using System;
using System.Collections.Generic;
using System.Text;
using XamarinProjectSimple.Models.ShopModels;

namespace XamarinProjectSimple.Services.Shop
{
    public interface IShopsService
    {
        IEnumerable<ShopModel> GetShopsList();
    }
}
