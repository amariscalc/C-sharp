/*
 * 2023/09/10
 */

// Import execution context
using System;
using System.Xml.Linq;
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
            string MyString = "This is a string";
            Console.WriteLine(MyString);          // This is a string  
            
            // Change the value
            MyString = "This is the new value";
            Console.WriteLine(MyString);          // This is the new value

            // INT
            int MyInt = 25;
            Console.WriteLine(MyInt);          // 25

            // Operate with an "int"
            MyInt = MyInt + 15;
            Console.WriteLine(MyInt);          // 40
            Console.WriteLine(MyInt + 2023);   // 2063
            Console.WriteLine(MyInt);          // 40

            // FLOAT
            float MyFloat = 1.81f;
            Console.WriteLine(MyFloat);        // 1.81

            // Double
            double MyDouble = 2.63;
            Console.WriteLine(MyDouble);       // 2.63

            // Operate with numerical variables
            Console.WriteLine((MyInt + MyDouble) * MyFloat);

            // Bool
            bool MyBool = true; 
            Console.WriteLine(MyBool);          // True
            MyBool = false;
            Console.WriteLine(MyBool);          // False

            // Print strings with other variable types
            Console.WriteLine ("The value of myInt is: " + MyInt + ".");  // The value of myInt is: 40.
            Console.WriteLine ($"The value of myDouble is: {MyDouble}."); // The value of myDouble is: 2,63.

            // Create a constant
            const double PI = 3.14159;
            Console.WriteLine (PI); // 3,14159

            const string MyName = "Alberto";
            Console.WriteLine (MyName); // Alberto

            // myName = "Pepe"; Error, "myName is a constant so you can´t change the value.

            
            //Dynamic variable
            dynamic myDinamycVar;
            myDinamycVar = "I´m a string";
            Console.WriteLine($"Type data of \"myDinamyVar\" is {myDinamycVar.GetType()}"); // Type data of "myDinamyVar" is System.String
            myDinamycVar = 100;
            Console.WriteLine($"Type data of \"myDinamyVar\" is {myDinamycVar.GetType()}"); // Type data of "myDinamyVar" is System.Int32

            // Convert type data

            string myAge = "35";
            int myAgeInt = Convert.ToInt32 (myAge);
            Console.WriteLine (myAgeInt);
            Console.WriteLine($"Type data of \"myAgeInt\" is {myAgeInt.GetType()}"); // Type data of "myAgeInt" is System.Int32

            Console.Write("Enter the age:");
            double myAgeDouble = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine ($"The age enter is: {myAgeDouble}");
            Console.WriteLine($"Type data of \"myAgeDouble\" is {myAgeDouble.GetType()}"); // Type data of "myAgeDouble" is System.Double

            Console.WriteLine ("Enter your phone number:");
            double myPhone = double.Parse (Console.ReadLine());
            Console.WriteLine($"Type data of \"myPhone\" is {myPhone.GetType()}"); // Type data of "myPhone" is System.Double

            // Structures
            // Array
            var MyArray = new string [] {"Alberto", "Mariscal", "Sevilla"};
            Console.WriteLine(MyArray[1]); // Mariscal

            int [] Numbers = {1,3,4,6,7,5,101};
            Console.WriteLine(Numbers [4]); // 7

            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write(Numbers [i]+ " "); // 1 3 4 6 7 5 101 
            }

            // The .Append() method on the array appends a value to the end of the sequence.
            MyArray = MyArray.Append("\nReal Betis Balompíe").ToArray();
            Console.WriteLine(MyArray[3]); // Real Betis Balompíe

            // Dictionary
            var MyDictionary = new Dictionary <string, int>
            {
                {"Id",432545332},
                {"Age",35},
                {"Km", 5500}
            };
            Console.WriteLine(MyDictionary["Id"]); // 432545332
            Console.WriteLine(MyDictionary["Age"]); // 35
            Console.WriteLine(MyDictionary["Km"]); // 5500

            // Read the Dictionary with a for loop
            for (int i=0; i< MyDictionary.Count; i++)
            {
                Console.WriteLine($"Key: {MyDictionary.Keys.ElementAt(i)}. Value: {MyDictionary.Values.ElementAt(i)}");
                /*
                Key: Id. Value: 432545332
                Key: Age. Value: 35
                Key: Km. Value: 5500
                */
            }

            // Sets
            var MySet = new HashSet<string> {"Almería","Huelva","Cádiz","Córdoba","Granada","Sevilla","Málaga","Jaén"};
            for (int i=0; i< MySet.Count; i++)
            {
                Console.WriteLine($"Value loop {i+1} {MySet.ElementAt(i)}");
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

            Console.WriteLine("Run mySet but We´ll use foreach"); // Run mySet but We´ll use foreach
            foreach (string items in MySet)
            {
                Console.WriteLine (items);
                /*
                 Almería
                 Huelva
                 Cádiz
                 Córdoba
                 Granada
                 Sevilla
                 Málaga
                 Jaén
                 */
            }

            // Tuples
            var MyTuple = Tuple.Create <int,int,int> (1,2,3);
            var MyOtherTuple = ("España","Portugal","Polonia","UK");
            Console.WriteLine(MyTuple);         // (1, 2, 3)
            Console.WriteLine(MyOtherTuple);    // (España, Portugal, Polonia, UK)

            // conditional if
            int Age = 35;
            string Name = "Alberto";
            string City = "Sevilla";
            string FavTeam = "Real Betis Balompié";

            if (Age == 35 && Name == "Alberto" && FavTeam == "Real Betis Balompié")
            {
                Console.WriteLine($"Hello {Name} I see....{Age} years old");
            }
            else if (Age != 35 || Name != "Alberto")
            {
                Console.WriteLine("You are not the boss. Access Denied");
            }
            else
            {
                Console.WriteLine("default print");
            }

            // While
            int numberWhile = 0;

            while (numberWhile < 10)
            {
                Console.WriteLine($"The \"numberWhile\" values is {numberWhile}");
                numberWhile++;
            }
            /*
                The "numberWhile" values is 0
                The "numberWhile" values is 1
                The "numberWhile" values is 2
                The "numberWhile" values is 3
                The "numberWhile" values is 4
                The "numberWhile" values is 5
                The "numberWhile" values is 6
                The "numberWhile" values is 7
                The "numberWhile" values is 8
                The "numberWhile" values is 9 
            */

            // Do While
            int numberDoWhile = 15;

            do
            {

                Console.WriteLine($"The \"numberDoWhile\" values is {numberDoWhile}");
                numberDoWhile++;

            } while (numberDoWhile < 10);
            // The "numberDoWhile" values is 15

            // Switch
            int day = 0;
            bool numValidate = false;
            do
            {
                try
                {
                    Console.Write("Please, enter the day number (1-7)");
                    day = Int32.Parse(Console.ReadLine());
                    numValidate = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect input");
                    numValidate = false;
                }
            } while (day < 1 || day > 7 || numValidate == false);

            switch (day)
            {
                case 1:
                    Console.WriteLine($"Day {day} of the week. Today is monday");
                    break;
                case 2:
                    Console.WriteLine($"Day {day} of the week. Today is tuesday");
                    break;
                case 3:
                    Console.WriteLine($"Day {day} of the week. Today is webnesday");
                    break;
                case 4:
                    Console.WriteLine($"Day {day} of the week. Today is thursday");
                    break;
                case 5:
                    Console.WriteLine($"Day {day} of the week. Today is friday");
                    break;
                case 6:
                    Console.WriteLine($"Day {day} of the week. Today is saturday");
                    break;
                case 7:
                    Console.WriteLine($"Day {day} of the week. Today is sunday");
                    break;
            }

            // Run functions
            myFunctions();
            double Result = funct_sum(5, 23);
            Console.WriteLine(Result);

            // Class
            var MyPet = new Pet ("Perro Paco",15);
            Console.WriteLine($"The dog´s name is {MyPet.Name} and he is {MyPet.Age} years old.");
            Console.ReadKey();
        // Functions
        void myFunctions ()
        {
            Console.WriteLine("Exec the function!");
        }
        double funct_sum(double Num1,double Num2)
        {
                double Sum = Num1 + Num2;
                return Sum;
        }
        

        }
    }
    class Pet
    {
        public string Name { get; set; }
        public int Age;
        public Pet (string NameP, int AgeP)
        {
            Name = NameP;
            Age = AgeP;
        }
    }
}
