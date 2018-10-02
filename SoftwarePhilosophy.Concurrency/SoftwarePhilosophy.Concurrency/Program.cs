using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePhilosophy.Concurrency
{
    class Program
    {
        static void Main(string[] args)
        {
            //Guid personId = Guid.NewGuid();
            //MessageSender.SendMessage(personId);
        }

        static void PrintPerson(Person person)
        {
            if (person != null)
            {
                if (person.Company != null)
                {
                    if (person.Company.City != null)
                    {
                        if (person.Company.City.Country != null)
                        {
                            Console.WriteLine($"{person.Company.City.Country.Title}-{person.Company.City.Title}-{person.Company.Title}-{person.Title}");
                        }
                    }
                }
            }
        }
    }
}
