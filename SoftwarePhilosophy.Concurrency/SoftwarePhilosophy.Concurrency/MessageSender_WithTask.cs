using System;
using System.Threading.Tasks;

namespace SoftwarePhilosophy.Concurrency
{
    class MessageSender_WithTask
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
            var countryTask = Task.Run(()=>LoadCountryOfPerson(personId));
            var messageTask = Task.Run(() => ApiUtil.LoadWelcomeMessage());

            Task.WaitAll(countryTask, messageTask);

            var country = countryTask.Result;
            var message = messageTask.Result;

            ApiUtil.SendSms(string.Format(message, country));
        }
    }
}