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

        async void btn_Map_Clicked(System.Object sender, System.EventArgs e)
        {
            var vm = (RestaurantDetalPageViewModel)BindingContext;

            await Navigation.PushModalAsync(
                new MapPage(
                    vm.Restaurant.Nombre,
                    vm.Restaurant.Direccion,
                    vm.Restaurant.Latitud,
                    vm.Restaurant.Longitud));
        }
    }
}
