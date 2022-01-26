using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAndLinq
{
    internal class PlanetsAndSpacecraft
    {
        internal void Run()
        {
            // **************************** PLANETS & SPACECRAFT EXERCISE
            Console.WriteLine("***** PLANETS *****");

            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            Console.WriteLine($"Starting planets: {string.Join(", ", planetList)}");

            // 1. `Add()` Jupiter and Saturn at the end of the list.
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            Console.WriteLine($"Added two: {string.Join(", ", planetList)}");

            // 2. Create another `List` that contains that last two planet of our solar system.
            List<string> remainingPlanets = new List<string> { "Uranus", "Neptune" };
            Console.WriteLine($"Final two: {string.Join(", ", remainingPlanets)}");

            // 3. Combine the two lists by using `AddRange()`.
            planetList.AddRange(remainingPlanets);
            Console.WriteLine($"Combined: {string.Join(", ", planetList)}");

            // 4. Use `Insert()` to add Earth, and Venus in the correct order.
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            Console.WriteLine($"Added Venus and Earth: {string.Join(", ", planetList)}");

            // 5. Use `Add()` again to add Pluto to the end of the list.
            planetList.Add("Pluto");
            Console.WriteLine($"Added Pluto: {string.Join(", ", planetList)}");

            // 6. Now that all the planets are in the list, slice the list using `GetRange()` in order to extract the rocky planets into a new list called `rockyPlanets`.
            List<string> rockyPlanets = planetList.GetRange(0, 4);
            Console.WriteLine($"Rocky planets: {string.Join(", ", rockyPlanets)}");

            // 7. Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the `Remove()` method to eliminate it from the end of `planetList`.
            planetList.Remove("Pluto");
            Console.WriteLine($"Removed Pluto: {string.Join(", ", planetList)}");

            // 1. Create a dictionary that will hold the name of a spacecraft
            //    that we have launched, and a list of names of the planets that it has
            //    visited. Remember that `List` is a Type just like native types (such as `string`, `int`, & `bool`) and your custom types (such as `Movie`, `Dog`, and `Food`).
            //    These types can be passed to anything, like a dictionary.
            Dictionary<string, List<string>> spacecraftVisits = new Dictionary<string, List<string>>()
                {
                    { "Mercury", new List<string>{"Mariner 10", "MESSENGER"} },
                    { "Venus", new List<string>{"Mariner 2", "Mariner 5", "Venera 5-16", "Magellan" } },
                    { "Earth", new List<string>{"Mariner 10", "Pioneer 10", "Pioneer 11", "Voyager 1", "Voyager 2" } },
                    { "Mars", new List<string>{ "Mariner 9", "Viking 1", "Viking 2", "Pathfinder", "Spirit", "Opportunity", "Perseverance"} },
                    { "Jupiter", new List<string>{ "Voyager 1", "Voyager 2"} },
                    { "Saturn", new List<string> { "Pioneer 11", "Voyager 1", "Voyager 2", "Cassini"} },
                    { "Uranus", new List<string> { "Voyager 2"} },
                    { "Neptune", new List<string> { "Voyager 2"} }
                };


            // 2. Iterate over your list of planets from above, and inside that loop,
            //    iterate over the dictionary. Write to the console, for each planet,
            //    which satellites have visited which planet.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***** SPACECRAFT *****");
            planetList.ForEach(p => Console.WriteLine($"{p} has been visited by: {string.Join(", ", spacecraftVisits[p])}"));

        }
    }
}
