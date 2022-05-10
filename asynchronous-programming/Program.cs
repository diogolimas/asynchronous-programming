using System;
using System.Threading.Tasks;

namespace asynchronous_programming
{
    public class Program
    {
        static void Main(string[] args)
        {
            var driver = new Driver();
            var verifier = new LoadVerifier();
            var assigner = new NewLoadAssigner();

            DateTime startTime = DateTime.Now;

            driver.ReportToBackOffice(); //require 5 seconds
            verifier.Verify(); // require 5 seconds
            assigner.Assign(); // require 5 seconds

            Console.WriteLine($"Total time taken: {DateTime.Now.Subtract(startTime).TotalSeconds}");
            //total: 15s

        }
    }

    public class Program1
    {
        static void Main(string[] args)
        {
            var driver = new Driver();
            var verifier = new LoadVerifier();
            var assigner = new NewLoadAssigner();

            DateTime startTime = DateTime.Now;

            //Running in Background
            Task.Run(() => driver.ReportToBackOffice()); //require 5 seconds
            Task.Run(() => verifier.Verify()); // require 5 seconds
            Task.Run(() => assigner.Assign()); // require 5 seconds


            Console.WriteLine($"Total time taken: {DateTime.Now.Subtract(startTime).TotalSeconds}");
            //total: 0.2s

        }
    }


    public class Program2
    {
        static async Task Main(string[] args)
        {
            var driver = new Driver();
            var verifier = new LoadVerifier();
            var assigner = new NewLoadAssigner();

            DateTime startTime = DateTime.Now;

            await Task.Run(() => driver.ReportToBackOffice()); //require 5 seconds
            await Task.Run(() => verifier.Verify()); // require 5 seconds
            await Task.Run(() => assigner.Assign()); // require 5 seconds


            Console.WriteLine($"Total time taken: {DateTime.Now.Subtract(startTime).TotalSeconds}");
            //total: 15s

        }
    }


    public class Program3
    {
        static async Task Main(string[] args)
        {
            var driver = new Driver();
            var verifier = new LoadVerifier();
            var assigner = new NewLoadAssigner();

            DateTime startTime = DateTime.Now;

            var driverTask = driver.ReportToBackOfficeAsync(); //require 5 seconds
            var verifierTask = verifier.VerifyAsync(); // require 5 seconds
            var assignerTask = assigner.AssignAsync(); // require 5 seconds

            Task.WaitAll(driverTask, verifierTask, assignerTask);

            Console.WriteLine($"Total time taken: {DateTime.Now.Subtract(startTime).TotalSeconds}");
            //total: 15s

        }
    }
}
