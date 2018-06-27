using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinProjectSimple.Models.ShopModels;

namespace XamarinProjectSimple.Views.Shop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShopsPage : ContentPage
    {
        public ShopsPage()
        {
            InitializeComponent();
            var imagesList = new List<ImageModel>()
            {
                new ImageModel(Color.Orange),
                new ImageModel(Color.Bisque),
                new ImageModel(Color.Blue),
                new ImageModel(Color.Green),
            };

            MyListView.ItemsSource = new ObservableCollection<ShopModel>()
            {
                new ShopModel("NameTest", "DescritiropawdDescritiropawdDescritiropawdDescritiropawdDescritiropawd", imagesList),
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
