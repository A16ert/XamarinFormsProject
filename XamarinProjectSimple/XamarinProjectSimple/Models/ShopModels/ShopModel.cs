using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace XamarinProjectSimple.Models.ShopModels
{
    public class ShopModel
    {
        public ShopModel() { }

        public ShopModel(IEnumerable<ImageModel> imagesList) => ImagesList = new List<ImageModel>(imagesList);

        public ShopModel(string name, string description, IEnumerable<ImageModel> imagesList)
        {
            Name = name;
            Description = description;

            ImagesList = new List<ImageModel>(imagesList);
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<ImageModel> ImagesList { get; set; }
    }

    public class ImageModel
    {
        public ImageModel(Color color) => ColorValue = color;
        public Color ColorValue { get; set; }
    }
}
