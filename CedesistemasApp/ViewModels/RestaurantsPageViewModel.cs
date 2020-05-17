using System.Collections.ObjectModel;
using CedesistemasApp.Models;
using CedesistemasApp.Repositories;

namespace CedesistemasApp.ViewModels
{
    public class RestaurantsPageViewModel : BaseViewModel
    {
        public ObservableCollection<RestaurantModel> Restaurantes { get; set; }
        private bool _IsRefreshingRestaurants;

        public bool IsRefreshingRestaurants
        {
            get { return _IsRefreshingRestaurants; }
            private set
            {
                _IsRefreshingRestaurants = value;
                OnPropertyChanged("IsRefreshingRestaurants");
            }
        }

        public RestaurantsPageViewModel()
        {
            Restaurantes = new ObservableCollection<RestaurantModel>();
            LoadRestaurants();
        }

        async private void LoadRestaurants()
        {
            IsRefreshingRestaurants = true;
            foreach (var restaurant in await new RestaurantRepository().GetRestaurants())
            {
                Restaurantes.Add(restaurant);
            }
            IsRefreshingRestaurants = false;
        }
    }
}
