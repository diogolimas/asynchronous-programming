using asynchronous_programming.Interfaces;
using System.Threading;

namespace asynchronous_programming
{
    public class LoadVerifier: ILoadVerifier
    {
        public bool Verify()
        {
            Thread.Sleep(5 * 1000);
            return true;
        }
    }
}
