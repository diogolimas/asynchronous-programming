using System;

namespace asynchronous_programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var driver = new Driver();
            var verifier = new LoadVerifier();
            var assigner = new NewLoadAssigner();

            driver.ReportToBackOffice();
            verifier.Verify();
            assigner.Assign();

        }
    }
}
