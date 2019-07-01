using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImagePage : ContentPage
	{
		public ImagePage ()
		{
			InitializeComponent ();

            //create image source in behind code
            //var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/400/200/sports/") };
            //imageSource.CachingEnabled = false;            
            //image.Aspect = Aspect.AspectFill;
            //image.Source = imageSource;

            //embeded resourse images
            //image.Source = ImageSource.FromResource("HelloWorld.Images.BackGround.jpg");

            //platform specific images
            //btn.Image = (FileImageSource) ImageSource.FromFile("clock.png");

        }
	}
}