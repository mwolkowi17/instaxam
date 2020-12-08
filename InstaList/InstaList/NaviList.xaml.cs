using InstaList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InstaList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NaviList : ContentPage
    {
        public NaviList()
        {
            InitializeComponent();
            list.ItemsSource = new List<User>()
            {
                new User()
                {
                 
                 Name="Marcin",
                 Description="szef xyz",
                 ImageUrl="https://lorempixel.com/100/100/people/1/"
                 
                },
                 new User()
                {

                 Name="Franek",
                 Description="mniejszy szef xyz",
                 ImageUrl="https://lorempixel.com/100/100/people/2/"
                },

                  new User()
                {

                 Name="Łucja",
                 Description="zastępca szefa xyz",
                 ImageUrl="https://lorempixel.com/100/100/people/3/"
                },

                  new User()
                  {
                      Name="Iwona",
                      Description = "common user",
                       ImageUrl="https://lorempixel.com/100/100/people/4/"
                  }
            };
        }

        async private void list_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var user=e.SelectedItem as User;
            await Navigation.PushAsync(new DetailPage(user));
            list.SelectedItem = null;
        }
    }
}