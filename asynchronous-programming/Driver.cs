using asynchronous_programming.Interfaces;
using System.Threading;

namespace asynchronous_programming
{
    public class Driver : IDriver
    {
        const int ONE_SECOND_IN_MS = 1000;

        public void ReportToBackOffice()
        {
            Thread.Sleep(5 * ONE_SECOND_IN_MS);
        }
    }
}
