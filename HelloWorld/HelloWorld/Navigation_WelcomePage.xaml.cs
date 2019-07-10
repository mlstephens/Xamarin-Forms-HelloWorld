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
    public partial class Navigation_WelcomePage : ContentPage
    {
        public Navigation_WelcomePage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Navigation_IntroductionPage());
        }
    }
}