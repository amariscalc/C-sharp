﻿// See https://aka.ms/new-console-template for more information
using System;


namespace SintaxisBasica2
{
    // By using a class, we can execute this file independently
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.Write ("Hello, guys!#\n");
            Console.WriteLine ("Please enter the necessary information.");
            //Console.ReadLine();

            Console.Write ("Name and surname: ");
            string NameSurname = Console.ReadLine ();
            // Console.WriteLine (NameSurname);
            Console.Write("Birth year: ");
            string Year = Console.ReadLine();
            Console.WriteLine ($"Your name is {NameSurname} and your birth year is {Year}.");
            
            Console.WriteLine("Please enter the necessary information.");

            

        }
    }
}
