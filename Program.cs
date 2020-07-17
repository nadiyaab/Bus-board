using System.Linq;
using System;

namespace Bus_Board
{
    class Program
    {
        static void Main(string[] args)
    {
        var transportApiClient = new TransportApiClient();

        var stopCode = GetStopCodeFromUser();

        var departures = transportApiClient.GetBusDepartureForStop(stopCode);

        PrintNextBuses(departures);
    }
     private static void PrintNextBuses(BusDepartureResponse departures)
     {
         Console.WriteLine($"\n\nNext buses at {departures.Name}");
         foreach (var departure in departures.Departures.All.Take(5))
         {
             Console.WriteLine($"Line: {departure.Line}, To: {departure.Direction}, Leaving at: {departure.ExpectedDepartureTime}");
         }
     }

     private static string GetStopCodeFromUser()
    {
        Console.WriteLine("Please enter the bus stop code:");
        return Console.ReadLine(); 
        }
        } 
    }
}
