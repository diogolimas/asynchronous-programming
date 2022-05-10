using asynchronous_programming.Interfaces;
using System.Threading;

namespace asynchronous_programming
{
    public class NewLoadAssigner: INewLoadAssigner
    {

        public void Assign() => Thread.Sleep(5 * 1000);
    }
}
