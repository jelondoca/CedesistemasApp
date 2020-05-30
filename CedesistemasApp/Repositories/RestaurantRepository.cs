using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CedesistemasApp.Interfaces;
using CedesistemasApp.Models;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace CedesistemasApp.Repositories
{
    public class RestaurantRepository
    {

        public IDeviceService DeviceService { get; set; }
        public IStorageService StorageService { get; set; }

        public RestaurantRepository()
        {
            DeviceService = DependencyService.Get<IDeviceService>();
            StorageService = DependencyService.Get<IStorageService>();
        }

        async public Task<List<RestaurantModel>> GetRestaurants()
        {
            if (DeviceService.CheckConnectivity())
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(new Uri("https://cedesistemas-app-api.azurewebsites.net/api/Restaurantes"));
                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        StorageService.Set("Restaurants", content);
                        return JsonConvert.DeserializeObject<List<RestaurantModel>>(content);
                    }
                }
            }
            else
            {
                string content = StorageService.Get("Restaurants").Result;
                return JsonConvert.DeserializeObject<List<RestaurantModel>>(content);
            }
            return null;
        }

        async public Task<List<ProductModel>> GetProducts(Guid restaurantId)
        {
            if (DeviceService.CheckConnectivity())
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(new Uri($"https://cedesistemas-app-api.azurewebsites.net/api/Restaurantes/{restaurantId}/Productos"));
                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        StorageService.Set($"Products_{restaurantId}", content);
                        return JsonConvert.DeserializeObject<List<ProductModel>>(content);
                    }
                }
            }
            else
            {
                string content = StorageService.Get($"Products_{restaurantId}").Result;
                return JsonConvert.DeserializeObject<List<ProductModel>>(content);
            }
            return null;
        }
    }
}
