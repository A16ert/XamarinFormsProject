using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using XamarinProjectSimple.Models.ShopModels;

[assembly: Xamarin.Forms.Dependency(typeof(XamarinProjectSimple.Services.Shop.ShopsService))]
namespace XamarinProjectSimple.Services.Shop
{
    
    public class ShopsService : IShopsService
    {
        public IEnumerable<ShopModel> GetShopsList()
        {
            var imagesList = new List<ImageModel>()
            {
                new ImageModel(Color.Orange),
                new ImageModel(Color.Bisque),
                new ImageModel(Color.Blue),
                new ImageModel(Color.Green),
            };

            return new List<ShopModel>()
            {
                new ShopModel("NameTest", @"Только до января 2018! СПЕЦИАЛЬНОЕ ПРЕДЛОЖЕНИЕ — успей купить 2" +
                                "сумки на сумму от 10000 рублейи получи кошелек и что то там ещё такое qwasd wqdas weqeqqq", imagesList),
                new ShopModel("NameTest", "DescritiropawdDescritiropawdDescritiropawdDescritiropawdDescritiropawd", imagesList),
                new ShopModel("NameTest", "DescritiropawdDescritiropawdDescritiropawdDescritiropawdDescritiropawd", imagesList),
                new ShopModel("NameTest", "DescritiropawdDescritiropawdDescritiropawdDescritiropawdDescritiropawd", imagesList),
                new ShopModel("NameTest", "DescritiropawdDescritiropawdDescritiropawdDescritiropawdDescritiropawd", imagesList),
                new ShopModel("NameTest", "DescritiropawdDescritiropawdDescritiropawdDescritiropawdDescritiropawd", imagesList),
                new ShopModel("NameTest", "DescritiropawdDescritiropawdDescritiropawdDescritiropawdDescritiropawd", imagesList)
            };
        }
    }
}
