using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoftwarePhilosophy.Concurrency
{
    class ApiUtil
    {
        public static Person LoadPerson(Guid id)
        {
            // Simulating the long operation.
            Thread.Sleep(TimeSpan.FromSeconds(3));

            return new Person();
        }

        public static Company LoadCompany(Guid id)
        {
            // Simulating the long operation.
            Thread.Sleep(TimeSpan.FromSeconds(3));

            return new Company();
        }

        public static City LoadCity(Guid id)
        {
            // Simulating the long operation.
            Thread.Sleep(TimeSpan.FromSeconds(3));

            return new City();
        }

        public static Country LoadCountry(Guid id)
        {
            // Simulating the long operation.
            Thread.Sleep(TimeSpan.FromSeconds(3));

            return new Country();
        }

        public static string LoadWelcomeMessage()
        {
            // Simulating the long operation.
            Thread.Sleep(TimeSpan.FromSeconds(3));

            return $"We are very happy to have you from {0}";
        }

        public static void SendSms(string text)
        {
            // Simulating the long operation.
            Thread.Sleep(TimeSpan.FromSeconds(3));
        }
    }
}
