using asynchronous_programming.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace asynchronous_programming
{
    public class LoadVerifier: ILoadVerifier
    {
        public bool Verify()
        {
            Thread.Sleep(5 * 1000);
            return true;
        }

        public async Task<bool> VerifyAsync()
        {
            await Task.Delay(5 * 1000);
            return true;
        }
    }
}
