using CollectionAndLinq;

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//create an instance of a new blank list
//List<int> listOfIntegers = new List<int>();

//int n = 15;

////Add method
//listOfIntegers.Add(1);
//listOfIntegers.Add(n);
////listOfIntegers.Add("Brian");  can only add things of the correct type

////Lists are iterable
//foreach (int num in listOfIntegers)
//{
//    Console.WriteLine(num);
//}

///**********************************
// * TUPLES
// *********/

//var product = Tuple.Create("Yo-yo", 1, 9.04, "Brian");
//Console.WriteLine($"{product.Item1} {product.Item2} {product.Item3} {product.Item4}");



////Dictionary - C# collection of KeyValuePair
////POJO - plain old javascript object
///*
// * const obj = {
// *  name: "Brian",
// *  title: "Instructor",
// *  cohort: 30
// * }
// * access your object's properties with square bracket notation or dot notation
// * obj["name"], obj.name
// * 
// * var dict = new Dictionary<string, string>()
// * {
// *  "name": "Brian"
// *  "title": "Instructor"
// *  "cohort": "C30"
// *  
// * };
// * access items with square bracket notation
// * dict[]
// */

//var dict = new Dictionary<int, string>();
//dict.Add(1, "One");
//dict.Add(2, "Two");
//dict.Add(3, "Three");
//dict.Add(4, "Four");

//Console.WriteLine(dict[1]);
//Console.WriteLine(dict[2]);

//foreach (KeyValuePair<int, string> kvp in dict)
//{
//    Console.WriteLine($"Key: {kvp.Key}  Value: {kvp.Value}");
//}


// examples of using List and Dictionary for hashmap lookup *************************

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
planetList.ForEach(p =>
{
    Console.WriteLine($"{p} has been visited by: {string.Join(", ", spacecraftVisits[p])}");
});

