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
    public partial class Navigation_IntroductionPage : ContentPage
    {
        public Navigation_IntroductionPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        //disables android backbutton funtionality
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}