using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAndLinq
{
    internal class RandomSquares
    {
        internal void Run()
        {
            /******************** RANDOM SQUARES EXERCISE *********************
            *
            * 1. Using the `Random` class, generate a list of 20 random numbers that are in the range of 1-50.
            * 2. With the resulting List, populate a new List that contains each number squared.
            *    For example, if the original list is `2, 5, 3, 15`, the final list will be `4, 25, 9, 225`.
            * 3. Then remove any number that is odd from the list of squared numbers.
            */

            // 1. Using the `Random` class, generate a list of 20 random numbers that are in the range of 1-50.
            var rand = new Random();
            var numbers = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                numbers.Add(rand.Next(1, 50));
            }

            // 2. With the resulting List, populate a new List that contains each number squared.
            // .Select is like .map in javascript, it will iterate the entire collection and return a collection of the same length, applying your code to each item
            var squaredNumbers = numbers.Select(n => n * n);

            // 3.Then remove any number that is odd from the list of squared numbers.
            // .Where is like .filter in javascript, it will return a collection containing items that meet the defined condition
            var evensOnly = squaredNumbers.Where(n => n % 2 == 0);

            Console.WriteLine($"Original random numbers: {string.Join(", ", numbers)}");
            Console.WriteLine($"Squared random numbers: {string.Join(", ", squaredNumbers)}");
            Console.WriteLine($"Only the evens: {string.Join(", ", evensOnly)}");
        }
    }
}
