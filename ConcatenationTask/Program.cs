﻿namespace ConcatenationTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FirstName;
string LastName;
int age;
Console.Write("Enter first name: ");
FirstName = Console.ReadLine();
Console.Write("Enter last name: ");
LastName = Console.ReadLine();
Console.WriteLine("Enter age: ");
age = Convert.ToInt32(Console.ReadLine());
           

// add two more variables for the users last name and their age
// take these inputs into the program
// use the test data Bob, Smith, 14
// ammend this code to output in one command
// Hello Bob Smith you are 14 years old 
Console.WriteLine("Hello " +FirstName+" "+LastName+" "+"you are "+age+" "+"years old");
// save and commit your program
//
// add evidence of the test input and your own input running the program .
        }
    }
}
