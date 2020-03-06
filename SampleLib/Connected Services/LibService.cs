using System;
using System.Threading.Tasks;
using Microsoft.OData.Service.Sample.TrippinInMemory.Models;

namespace SampleLib
{
    public static class LibService
    {
        private static string serviceUri = "https://services.odata.org/TripPinRESTierService/";
        private static Container context = new Container(new Uri(serviceUri));

        public static async Task<string> GetMostPopularPerson()
        {
            var person = await context.GetPersonWithMostFriends().GetValueAsync();
            return $"{person.FirstName} { person.LastName}";
        }
    }
}