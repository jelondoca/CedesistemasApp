using System;
using System.Collections.Generic;
using CedesistemasApp.ViewModels;
using Xamarin.Forms;

namespace CedesistemasApp.Views
{
    public partial class RestaurantDetalPage : ContentPage
    {
        public RestaurantDetalPage()
        {
            InitializeComponent();
        }

        public RestaurantDetalPage(RestaurantDetalPageViewModel restaurantDetalPageViewModel)
        {
            InitializeComponent();
            BindingContext = restaurantDetalPageViewModel;
        }
    }
}
