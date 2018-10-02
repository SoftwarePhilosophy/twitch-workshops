using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePhilosophy.Concurrency
{
    class Person
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }

    class Company
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid CityId { get; set; }
        public City City { get; set; }
    }

    class City
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid CountryId { get; set; }

        public Country Country { get; set; }
    }

    class Country
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
    }
}
