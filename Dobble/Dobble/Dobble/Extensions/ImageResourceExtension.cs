using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dobble.Extensions
{
    [ContentProperty("Source")]
    public class ImageResourceExtension : IMarkupExtension
    {
        public string Source { get; set; }
        public Object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
            {
                return null;
            }
            var imageSource = ImageSource.FromResource(Source);
            return imageSource;
        }
    }
}
