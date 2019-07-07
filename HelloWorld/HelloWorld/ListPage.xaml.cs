using HelloWorld.Models;
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
	public partial class ListPage : ContentPage
	{
		public ListPage ()
		{
			InitializeComponent ();

            //simple lists
            listView.ItemsSource = new List<Contact>
            {
                new Contact{ Name="Anna", ImageUrl="http://lorempixel.com/100/100/people/1" },
                new Contact{ Name="Mosh", Status="Text me please.", ImageUrl="http://lorempixel.com/100/100/people/3" }
            };

            //grouping
            //listView.ItemsSource = new List<ContactGroup>
            //{
            //    new ContactGroup("A","A"){
            //        new Contact{ Name="Anna", ImageUrl="http://lorempixel.com/100/100/people/1" },
            //    },

            //    new ContactGroup("M","M")
            //    {
            //        new Contact{ Name="Mosh", Status="Text me please.", ImageUrl="http://lorempixel.com/100/100/people/3" }
            //    }
            //};
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            DisplayAlert("Tapped:", contact.Name, "OK");
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            DisplayAlert("Selected:", contact.Name, "OK");
        }
    }
}