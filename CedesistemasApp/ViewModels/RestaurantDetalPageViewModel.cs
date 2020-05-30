using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CedesistemasApp.Interfaces;
using CedesistemasApp.Models;
using CedesistemasApp.Repositories;
using Xamarin.Forms;

namespace CedesistemasApp.ViewModels
{
    public class RestaurantDetalPageViewModel : BaseViewModel
    {
        public ICommand OpenUrlCommand { get; set; }
        public ICommand PhoneCallCommand { get; set; }
        public ObservableCollection<ProductModel> Productos { get; set; }
        public RestaurantModel Restaurant { get; }
        private IDeviceService deviceService;

        public RestaurantDetalPageViewModel(RestaurantModel item)
        {
            OpenUrlCommand = new Command(OpenUrl);
            PhoneCallCommand = new Command(PhoneCall);
            Productos = new ObservableCollection<ProductModel>();
            this.Restaurant = item;
            this.deviceService = DependencyService.Get<IDeviceService>();
            LoadProducts();
        }

        async private void LoadProducts()
        {
            foreach (var restaurant in await new RestaurantRepository().GetProducts(this.Restaurant.Id))
            {
                Productos.Add(restaurant);
            }
        }

        private void OpenUrl()
        {
            this.deviceService.OpenBrowser(Restaurant.SitioWeb);
        }

        private void PhoneCall()
        {
            this.deviceService.PlacePhoneCall(Restaurant.Telefono);
        }
    }
}
