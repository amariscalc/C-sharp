/*
 * 2023/09/10
 */

// Import execution context
using System;
using Microsoft.VisualBasic;

// Create a namespace
namespace CSharpHelloWorld
{
    // By using a class, we can execute this file independently
    class HelloWorld
    {
        static void Main(string[] args)
        {
            // STRINGS
            // Print a message to the console output
            Console.WriteLine("Hello, World!!!");  // Hello, World!!!
            
            // Data types
            string myString = "This is a string";
            Console.WriteLine(myString);          // This is a string  
            
            // Change the value
            myString = "This is the new value";
            Console.WriteLine(myString);          // This is the new value

            // INT
            int myInt = 25;
            Console.WriteLine(myInt);          // 25
            
            // Operate with an "int"
            myInt = myInt + 15;
            Console.WriteLine(myInt);          // 40
            Console.WriteLine(myInt + 2023);   // 2063
            Console.WriteLine(myInt);          // 40

            // FLOAT
            float myFloat = 1.81f;
            Console.WriteLine(myFloat);        // 1.81

            // Double
            double myDouble = 2.63;
            Console.WriteLine(myDouble);       // 2.63

            // Operate with numerical variables
            Console.WriteLine((myInt + myDouble) * myFloat);

            // Bool
            bool myBool = true; 
            Console.WriteLine(myBool);          // True
            myBool = false;
            Console.WriteLine(myBool);          // False

            // Print strings with other variable types
            Console.WriteLine ("The value of myInt is: " + myInt + ".");  // The value of myInt is: 40.
            Console.WriteLine ($"The value of myDouble is: {myDouble}."); // The value of myDouble is: 2,63.

            // Create a constant
            const double PI = 3.14159;
            Console.WriteLine (PI); // 3,14159

            const string myName = "Alberto";
            Console.WriteLine (myName); // Alberto

            // myName = "Pepe"; Error, "myName is a constant so you can´t change the value.

            // Structures
            // Array
            var myArray = new string [] {"Alberto", "Mariscal", "Sevilla"};
            Console.WriteLine(myArray [1]); // Mariscal

            int [] numbers = {1,3,4,6,7,5,101};
            Console.WriteLine(numbers [4]); // 7

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers [i]+ " "); // 1 3 4 6 7 5 101 
            }
            
            // The .Append() method on the array appends a value to the end of the sequence.
            myArray = myArray.Append("Real Betis Balompíe").ToArray();
            Console.WriteLine(myArray [3]); // Real Betis Balompíe

            // Dictionary
            var myDictionary = new Dictionary <string, int>
            {
                {"Id",432545332},
                {"Age",35},
                {"Km", 5500}
            };
            Console.WriteLine(myDictionary ["Id"]); // 432545332
            Console.WriteLine(myDictionary ["Age"]); // 35
            Console.WriteLine(myDictionary ["Km"]); // 5500

            // Read the Dictionary with a for loop
            for (int i=0; i<myDictionary.Count; i++)
            {
                Console.WriteLine($"Key: {myDictionary.Keys.ElementAt(i)}. Value: {myDictionary.Values.ElementAt(i)}");
                /*
                Key: Id. Value: 432545332
                Key: Age. Value: 35
                Key: Km. Value: 5500
                */
            }

            // Sets
            var mySet = new HashSet<string> {"Almería","Huelva","Cádiz","Córdoba","Granada","Sevilla","Málaga","Jaén"};
            for (int i=0; i<mySet.Count; i++)
            {
                Console.WriteLine($"Value loop {i+1} {mySet.ElementAt(i)}");
                /*
                Value loop 1 Almería
                Value loop 2 Huelva
                Value loop 3 Cádiz
                Value loop 4 Córdoba
                Value loop 5 Granada
                Value loop 6 Sevilla
                Value loop 7 Málaga
                Value loop 8 Jaén
                */
            }

            // Tuples
            var myTuple  = Tuple.Create <int,int,int> (1,2,3);
            var myOtherTuple = ("España","Portugal","Polonia","UK");
            Console.WriteLine(myTuple);         // (1, 2, 3)
            Console.WriteLine(myOtherTuple);    // (España, Portugal, Polonia, UK)


            // conditional if

            // WORKING IN PROGRESS

        }
    }
}