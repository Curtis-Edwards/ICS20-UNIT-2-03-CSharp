using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        string name;
        int age;

        Console.WriteLine("Your age and name. Please.");
        Console.WriteLine("");

        Console.Write("Your name please: ");
        name = Console.ReadLine();
        Console.Write("Your age please: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("Your info is: " + name + ", age " + age + ". My name is also " + name + ".");

        Console.WriteLine("\nDone.");
    }
}