using System; 
using System.Threading.Tasks;
using Microsoft.OData.Service.Sample.TrippinInMemory.Models;
static class Program
{
    static string serviceUri = "https://services.odata.org/TripPinRESTierService/";
    static Container context = new Container(new Uri(serviceUri));
    static void Main()
    {
        ShowPeople().Wait();
        Console.WriteLine("Most popular: {0}", SampleLib.LibService.GetMostPopularPerson().Result);
    }

    static async Task ShowPeople()
    {
        var people = await context.People.ExecuteAsync();
        foreach (var person in people)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}