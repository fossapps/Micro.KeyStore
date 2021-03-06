using System.Threading.Tasks;

namespace Micro.KeyStore.Api.Archive.drivers
{
    public class Noop<T> : IDriver<T>
    {
        public Task Save(T item)
        {
            return Task.CompletedTask;
        }
    }
}
