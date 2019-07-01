using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImagePageExercise : ContentPage
	{
		public ImagePageExercise ()
		{
			InitializeComponent ();

            //create image source in behind code
            var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/city/1") };
            imageSource.CachingEnabled = false;
            image.Aspect = Aspect.AspectFill;
            image.Source = imageSource;
        }
    }
}