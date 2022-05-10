using System.Threading.Tasks;

namespace asynchronous_programming.Interfaces
{
    public interface IDriver
    {

        void ReportToBackOffice();
        Task ReportToBackOfficeAsync();
    }
}
