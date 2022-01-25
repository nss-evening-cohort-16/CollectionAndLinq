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



////Dictionary
////POJO
///*
// * {
// *  name: "Brian",
// *  title: "Instructor",
// *  cohort: 30
// * }
// * obj["name"], obj.name
// * 
// * {
// *  1: "One"
// *  2: "Two"
// *  
// * }
// * dict[1]
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

var hash = new Dictionary<string, int>();
var moreComplexHash = new Dictionary<string, List<Car>>();

foreach (Car car in cars)
{
    //hashmap
    if (hash.ContainsKey(car.Make))
    {
        hash[car.Make]++;
    }
    else
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

    foreach (var item in hash)
    {
        Console.WriteLine($"{item.Key}, {item.Value}");
    }

    foreach (var item in moreComplexHash)
    {
        Console.WriteLine($"{item.Key}, {item.Value.Count}");
    }
