using CollectionAndLinq;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

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


    if (moreComplexHash.ContainsKey(car.Make))
    {
        moreComplexHash[car.Make].Add(car);
    }
    else
    {
        moreComplexHash.Add(car.Make, new List<Car>());
        moreComplexHash[car.Make].Add(car);
    }
}

foreach (KeyValuePair<string, int> kvp in hash)
{
    Console.WriteLine($"{kvp.Key}, {kvp.Value}");
}

foreach (KeyValuePair<string, List<Car>> kvp in moreComplexHash)
{
    Console.WriteLine($"{kvp.Key}, {kvp.Value.Count}");
}

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
var squaredNumbers = numbers.Select(n => n * n);

// 3.Then remove any number that is odd from the list of squared numbers.
var evensOnly = squaredNumbers.Where(n => n % 2 == 0);

/***************** 
 * 
 */

