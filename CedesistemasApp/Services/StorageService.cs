using System;
using System.Threading.Tasks;
using CedesistemasApp.Interfaces;
using CedesistemasApp.Services;
using Xamarin.Essentials;

[assembly: Xamarin.Forms.Dependency(typeof(StorageService))]
namespace CedesistemasApp.Services
{
    public class StorageService : IStorageService
    {
        async public Task<string> Get(string key)
        {
            try
            {
                var value = await SecureStorage.GetAsync(key);
                return value;
            }
            catch(Exception ex)
            {

            }
            return null;
        }

        async public void Set(string key, string value)
        {
            await SecureStorage.SetAsync(key, value);
        }

    }
}
