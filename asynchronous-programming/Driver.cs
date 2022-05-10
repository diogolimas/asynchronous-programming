using asynchronous_programming.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace asynchronous_programming
{
    public class Driver : IDriver
    {
        const int ONE_SECOND_IN_MS = 1000;

        public void ReportToBackOffice()
        {
            Thread.Sleep(5 * ONE_SECOND_IN_MS);
        }

        public async Task ReportToBackOfficeAsync()
        {
            await Task.Delay(5 * ONE_SECOND_IN_MS);
        }
    }
}
