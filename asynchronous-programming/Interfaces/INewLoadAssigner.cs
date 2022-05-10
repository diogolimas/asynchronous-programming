using System.Threading.Tasks;

namespace asynchronous_programming.Interfaces
{
    public interface INewLoadAssigner
    {
        Task AssignAsync();
        void Assign();
    }
}
