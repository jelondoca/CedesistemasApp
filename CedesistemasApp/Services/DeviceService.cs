using System;
using CedesistemasApp.Interfaces;
using CedesistemasApp.Services;
using Xamarin.Essentials;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceService))]
namespace CedesistemasApp.Services
{
    public class DeviceService: IDeviceService
    {
        public bool CheckConnectivity()
        {
            var current = Connectivity.NetworkAccess;
            return current == NetworkAccess.Internet;
        }

        async public void OpenBrowser(string url)
        {
            if (CheckConnectivity())
            {
                var uri = new Uri(url);
                await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
        }

        public void PlacePhoneCall(string phoneNumber)
        {
            try
            {
                PhoneDialer.Open(phoneNumber);
            }
            catch (ArgumentNullException anEx)
            {

            }
            catch (FeatureNotSupportedException ex)
            {
                // Phone Dialer is not supported on this device.
            }
            catch (Exception ex)
            {
                // Other error has occurred.
            }
        }
    }
}
