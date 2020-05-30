using System;
using System.Threading.Tasks;

namespace CedesistemasApp.Interfaces
{
    public interface IStorageService
    {
        void Set(string key, string value);

        Task<string> Get(string key);
    }
}
