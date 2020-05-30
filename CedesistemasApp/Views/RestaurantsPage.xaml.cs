using System;
using System.Collections.Generic;
using CedesistemasApp.Models;
using CedesistemasApp.ViewModels;
using Xamarin.Forms;

namespace CedesistemasApp.Views
{
    public partial class RestaurantsPage : ContentPage
    {
        public RestaurantsPage()
        {
            InitializeComponent();
            BindingContext = new RestaurantsPageViewModel();
        }

        private async void grd_restaurants_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as RestaurantModel;
            if (item == null)
                return;
            grd_restaurants.SelectedItem = null;
            await Navigation.PushAsync(new RestaurantDetalPage(new RestaurantDetalPageViewModel(item)));
        }

    }
}
