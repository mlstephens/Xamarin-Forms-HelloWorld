using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GreetingPage : ContentPage
	{
		public GreetingPage ()
		{
			InitializeComponent();
            slider.Value = 0.5;

            // how to set device related code etc. this sets padding
            //Padding = Device.OnPlatform(
            //    iOS: new Thickness(0, 20, 0, 0),
            //    Android: new Thickness(0, 50, 0, 0),
            //    WinPhone: new Thickness(0, 10, 0, 0)
            //);
        }
    }
}