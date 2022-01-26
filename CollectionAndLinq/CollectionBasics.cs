using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAndLinq
{
    internal class CollectionBasics
    {
        internal void Run()
        {
            //create an instance of a new blank list
            List<int> listOfIntegers = new List<int>();

            int n = 15;

            //Add method
            listOfIntegers.Add(1);
            listOfIntegers.Add(n);
            //listOfIntegers.Add("Brian");  can only add things of the correct type

            //Lists are iterable
            foreach (int num in listOfIntegers)
            {
                Console.WriteLine(num);
            }

            /**********************************
             * TUPLES
             *********/

            var product = Tuple.Create("Yo-yo", 1, 9.04, "Brian");
            Console.WriteLine($"{product.Item1} {product.Item2} {product.Item3} {product.Item4}");



            //Dictionary - C# collection of KeyValuePair
            //POJO - plain old javascript object
            /*
             * const obj = {
             *  name: "Brian",
             *  title: "Instructor",
             *  cohort: 30
             * }
             * access your object's properties with square bracket notation or dot notation
             * obj["name"], obj.name
             * 
             * var dict = new Dictionary<string, string>()
             * {
             *  "name": "Brian"
             *  "title": "Instructor"
             *  "cohort": "C30"
             *  
             * };
             * access items with square bracket notation
             * dict[]
             */

            var dict = new Dictionary<int, string>();
            dict.Add(1, "One");
            dict.Add(2, "Two");
            dict.Add(3, "Three");
            dict.Add(4, "Four");

            Console.WriteLine(dict[1]);
            Console.WriteLine(dict[2]);

            foreach (KeyValuePair<int, string> kvp in dict)
            {
                Console.WriteLine($"Key: {kvp.Key}  Value: {kvp.Value}");
            }


            //examples of using List and Dictionary for hashmap lookup *************************

            var cars = new List<Car>();

            cars.Add(new Car("Toyota", "Camry", 2022));
            cars.Add(new Car("Toyota", "Corrolla", 1990));
            cars.Add(new Car("Toyota", "Forerunner", 2015));
            cars.Add(new Car("Ford", "F150", 2020));
            cars.Add(new Car("Ford", "Taurus", 2001));
            cars.Add(new Car("Tesla", "X", 2022));


            //the key is the car Make and the value is how many we've counted so far
            var hash = new Dictionary<string, int>();

            //the key is the car Make and the value is a collection of cars of that Make
            var moreComplexHash = new Dictionary<string, List<Car>>();

            foreach (Car car in cars)
            {
                //hashmap
                if (hash.ContainsKey(car.Make)) //if the key already exists ("Toyota") then just add 1 to the counter for that key
                {
                    hash[car.Make]++;
                }
                else //the key doesn't exist yet, so it's the first car of that Make, add the key with a count value of 1
                {
                    hash.Add(car.Make, 1);
                }


                if (moreComplexHash.ContainsKey(car.Make)) //if the key already exists ("Toyota") then just add the car to the collection
                {
                    moreComplexHash[car.Make].Add(car);
                }
                else  //the key doesn't exist yet, so it's the first car of that Make. Add the key along with a new List containing the car for its value
                {
                    moreComplexHash.Add(car.Make, new List<Car> { car });
                }
            }

            Console.WriteLine("Simpler hash *************");
            foreach (KeyValuePair<string, int> kvp in hash)
            {
                Console.WriteLine($"{kvp.Key}, {kvp.Value}");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("More complex hash *************");
            foreach (KeyValuePair<string, List<Car>> kvp in moreComplexHash)
            {
                Console.WriteLine($"{kvp.Key}, {kvp.Value.Count}");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
