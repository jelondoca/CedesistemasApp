using System;
namespace CedesistemasApp.Interfaces
{
    public interface IDeviceService
    {
        bool CheckConnectivity();

        void OpenBrowser(string url);

        void PlacePhoneCall(string phoneNumber);
    }
}
