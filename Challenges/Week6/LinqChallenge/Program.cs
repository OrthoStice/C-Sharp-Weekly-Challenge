﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using CsvHelper;
using CsvHelper.Configuration;

namespace LinqChallenge
{
    class Program
    {
        public static List<Airport> Airports;
        public static List<Route> Routes;
        public static List<Airline> Airlines;

        static void Main(string[] args)
        {
            // Data came from:  http://openflights.org/data.html
            // I had to modify routes.csv to change the original "\N" to -1's

            LoadDataFromCsvFiles();

            NewQuestion();
            Console.WriteLine("What are the airports in Louisville?");

            var airportsInLouisville =
                from a in Airports
                where a.City == "Louisville"
                select a;

            foreach (var a in airportsInLouisville)
                {
                    Console.WriteLine();
                    Console.WriteLine(a.ToString());
                }

            NewQuestion();

            Console.WriteLine("What is the Latitude/Longitude of KSDF?");

            var latitudeAndLongitude = Airports
                .Where(a => a.ICAO == "KSDF");

            NewQuestion();

            Console.WriteLine("How many routes originate in in louisville? ");

            NewQuestion();

            Console.WriteLine("How many routes terminate in Louisville?");

            NewQuestion();

            Console.WriteLine("Give me a list of Countries and how many airports in each country, as long as they have more than 100 airports?");

            // If you get this far, this is probably good enough skills for being able to do your class project. 
            // But if you want to challenge yourself, keep on! 

            NewQuestion(); 
       
            Console.WriteLine("Of the flights that leave Louisville, where do they go and which airline? I want sorted Airport Names, Airline");
            // hint 1:  Join once 
            // hint 2:  then join again 
            
            NewQuestion();

            Console.WriteLine("Which 5 airports are have the most flights taking off? (and how many flights)");
            Console.WriteLine("I want airport name and number of flights.");

            // hint 1: calculate number of flights taking off per airport id
            // hint 2: join to airports
            // hint 3: order by descending
            // hint 4: take 5

            // note -- if you start at airports and then try to do a count of routes, you hit an O(N^2) that causes some CPU spikeing. 
            // note -- another complexity is could have "most flights (taking off or landing)" -- that's more calculation and more joining.

            Console.ReadKey();

            // I could not come up with a MEANINGFUL GroupJoin question to ask that had displayable data with Airline data.

        }

        private static void NewQuestion()
        {
            Console.WriteLine();
            Console.WriteLine("=========================");
        }

        public static void LoadDataFromCsvFiles()
        {
            Airports = ReadCSV<Airport>("airports.csv");
            Console.WriteLine($"Read {Airports.Count} airports");

            Airlines = ReadCSV<Airline>("airlines.csv");
            Console.WriteLine($"Read {Airlines.Count} airlines");

            Routes = ReadCSV<Route>("routes.csv");
            Console.WriteLine($"Read {Routes.Count} routes");

        }

        private static List<T> ReadCSV<T>(string fileName)
        {
            List<T> records;
            using (var reader = new StreamReader(fileName))
            {
                using (var csv = new CsvReader(reader, new CsvConfiguration()
                {
                    HasHeaderRecord = false,
                    IgnoreBlankLines = true,
                    ThrowOnBadData = false
                }))
                {
                    records = csv.GetRecords<T>().ToList();
                }
            }
            return records;
        }

        public class Airport
        {
            public int AirportId { get; set; }
            public string AirportName { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
            public string IATA { get; set; }
            public string ICAO { get; set; }
            public decimal Latitude { get; set; }
            public decimal Longitude { get; set; }
            public int Altitude { get; set; }
            public decimal TimezoneOffset { get; set; }
            public  string DST { get; set; }
            public string Timezone { get; set; }

            public override string ToString()
            {
                return $"{AirportName}({City}, {Country}) [{IATA}/{ICAO}] "; 
            }
        }

        public class Airline
        {
            public int AirlineId { get; set; }
            public string AirlineName { get; set; }
            public string AirlineAlias { get; set; }
            public string IATA { get; set; }
            public string ICAO { get; set; }
            public string Callsign { get; set; }
            public string Country { get; set; }
            public bool IsActive { get; set; }

            public override string ToString()
            {
                return $"{AirlineName} ({Country}) [{IATA}/{ICAO}]";
            }
        }

        public class Route
        {
            public string IATA { get; set; }
            public int AirlineId { get; set; }
            public string SourceAirport { get; set; }
            public int SourceAirportId { get; set; }
            public string DestinationAirport { get; set; }
            public int DestinationAirportId { get; set; }
            public string IsCodeShare { get; set; }
            public string Stops { get; set; }
            public string Equipment { get; set; }

            public override string ToString()
            {
                return $"{IATA} {SourceAirport}->{DestinationAirport}";
            } 
        }

        public class City
        {
            public string CityName { get; set; }
            public int Population { get; set; }
            public int Class { get; set; }
            public string Area { get; set; }
            public int IncorporatedYear { get; set; }
            public string County { get; set; }
        }
    }
}
class QueryVMethodSyntax
{
    static void Main()
    {
        int[] numbers = { 5, 10, 8, 3, 6, 12 };

        //Query syntax:
        IEnumerable<int> numQuery1 =
            from num in numbers
            where num % 2 == 0
            orderby num
            select num;

        //Method syntax:
        IEnumerable<int> numQuery2 = numbers.Where(num => num % 2 == 0).OrderBy(n => n);

        foreach (int i in numQuery1)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine(System.Environment.NewLine);
        foreach (int i in numQuery2)
        {
            Console.Write(i + " ");
        }

        // Keep the console open in debug mode.
        Console.WriteLine(System.Environment.NewLine);
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }
}