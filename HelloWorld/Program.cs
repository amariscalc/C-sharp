/*
 * 2023/09/10
 */

// Import context execution
using System;

// Create a namespace
namespace CSharpHelloWorld
{
    // We can compile and execute this file without executing as in a project. For this one we should create a class
    class HelloWorld
    {
        static void Main(string[] args)
        {
            //  STRINGS
            // print a message to console output
            Console.WriteLine("Hello, World!!!");  // Hello, World!!!
            // Data types
            string myString = "This is a string";
            Console.WriteLine (myString);          // This is a string  
            // Change the value
            myString = "This is the new value";
            Console.WriteLine (myString);          // This is the new value

            // INT
            int myInt = 25;
            Console.WriteLine (myInt);          // 25
            // operate with a "int"
            myInt = myInt + 15;
            Console.WriteLine (myInt);          // 40
            Console.WriteLine (myInt + 2023);   // 2063
            Console.WriteLine (myInt);          // 40

            // FLOAT
            float myFloat = 1.81f;
            Console.WriteLine (myFloat);        // 1,81

            // Double
            double myDouble = 2.63;
            Console.WriteLine (myDouble);       // 2,63

            // Operate with numerical variables
            Console.WriteLine ((myInt + myDouble) * myFloat);

        }
    }
}
