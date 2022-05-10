using asynchronous_programming.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace asynchronous_programming
{
    public class NewLoadAssigner: INewLoadAssigner
    {

        public void Assign() => Thread.Sleep(5 * 1000);
        public async Task AssignAsync() => await Task.Delay(5 * 1000);
    }
}
