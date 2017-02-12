using System;

namespace _02.AdvertisementMessage
{
    class Program
    {
        static void Main()
        {
            string[] phrases = new []{"Excellent product.", "Such a great product.", 
                "I always use that product.", "Best product of its category.", "Exceptional product.", 
                "I can’t live without this product."};
            string[] events = new[]
            {
                "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!"
            };
            string[] author = new[] {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
            string[] cities = new[] {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            var randomPhrase = new Random();
            var randomEvents = new Random();
            var randomAuthor = new Random();
            var randomCities = new Random();

            Console.Write(phrases[randomPhrase.Next(0, phrases.Length)]);
            Console.Write(events[randomEvents.Next(0,events.Length)]);
            Console.Write(author[randomAuthor.Next(0,author.Length)] + " - ");
            Console.WriteLine(cities[randomCities.Next(0,cities.Length)]);

        }
    }
}
