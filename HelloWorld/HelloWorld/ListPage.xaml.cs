﻿using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        private ObservableCollection<Contact> _contacts;

        public ListPage()
        {
            InitializeComponent();

            //simple lists
            //_contacts = new ObservableCollection<Contact>
            //{
            //    new Contact{ Name="Anna", ImageUrl="http://lorempixel.com/100/100/people/1" },
            //    new Contact{ Name="Mosh", Status="Text me please.", ImageUrl="http://lorempixel.com/100/100/people/3" }
            //};
            //listView.ItemsSource = _contacts;

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

            listView.ItemsSource = GetContacts("");
        }

        private IEnumerable<Contact> GetContacts(string searchText)
        {
            var contacts = new List<Contact>
                {
                    new Contact{ Name="Anna", Status="Online", ImageUrl="http://lorempixel.com/100/100/people/1" },
                    new Contact{ Name="Mosh", Status="OffLine - Text Anna please.", ImageUrl="http://lorempixel.com/100/100/people/3" },
                    new Contact{ Name="John", Status="Online", ImageUrl="http://lorempixel.com/100/100/people/7" }
                };

            if (String.IsNullOrWhiteSpace(searchText))
            {
                return contacts;
            };

            return contacts.Where(c => c.Name.StartsWith(searchText)).ToList();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            listView.ItemsSource = GetContacts(e.NewTextValue.ToUpper());
        }

        //private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        //{
        //    var contact = e.Item as Contact;
        //    DisplayAlert("Tapped:", contact.Name, "OK");
        //}
        //private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    var contact = e.SelectedItem as Contact;
        //    DisplayAlert("Selected:", contact.Name, "OK");
        //}

        //private void Call_Clicked(object sender, EventArgs e)
        //{
        //    var contact = (sender as MenuItem).CommandParameter as Contact;
        //    DisplayAlert("Call:", contact.Name, "OK");
        //}
        //private void Delete_Clicked(object sender, EventArgs e)
        //{
        //    var contact = (sender as MenuItem).CommandParameter as Contact;
        //    _contacts.Remove(contact);
        //}

        //private void ListView_Refreshing(object sender, EventArgs e)
        //{
        //    listView.ItemsSource = GetContacts();
        //    listView.EndRefresh();
        //}



    }
}