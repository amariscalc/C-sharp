// See https://aka.ms/new-console-template for more information
using System;


namespace SintaxisBasica2
{
    // By using a class, we can execute this file independently
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Hello, guys!");
            Console.WriteLine ("Please enter the necessary information.");
            Console.Write ("Name and surname: ");
            string nameSurname = Console.ReadLine ();
            Console.WriteLine (nameSurname);

        }
    }
}
