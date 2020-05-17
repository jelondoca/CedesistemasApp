using System;
using System.Collections.ObjectModel;
using CedesistemasApp.Models;
using CedesistemasApp.Repositories;

namespace CedesistemasApp.ViewModels
{
    public class RestaurantDetalPageViewModel : BaseViewModel
    {
        public ObservableCollection<ProductModel> Productos { get; set; }
        public RestaurantModel Restaurant { get; }

        public RestaurantDetalPageViewModel(RestaurantModel item)
        {
            Productos = new ObservableCollection<ProductModel>();
            this.Restaurant = item;
            LoadProducts();
        }

        async private void LoadProducts()
        {
            foreach (var restaurant in await new RestaurantRepository().GetProducts(this.Restaurant.Id))
            {
                Productos.Add(restaurant);
            }
        }
    }
}
