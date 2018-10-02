using System;

namespace SoftwarePhilosophy.Concurrency
{
    class MessageSender
    {
        private static Country LoadCountryOfPerson(Guid personId)
        {
            var person = ApiUtil.LoadPerson(personId);
            var company = ApiUtil.LoadCompany(person.CompanyId);
            var city = ApiUtil.LoadCity(company.CityId);
            var country = ApiUtil.LoadCountry((city.CountryId));

            return country;
        }

        public static void SendMessage(Guid personId)
        {
            var country = LoadCountryOfPerson(personId);
            var message = ApiUtil.LoadWelcomeMessage();

            ApiUtil.SendSms(string.Format(message, country));
        }
    }
}