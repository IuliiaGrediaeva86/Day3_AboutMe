// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        string name = "Yulia";
        int age = 29;
        float height = 1.58f;
        char gender = 'F';

        Console.WriteLine("Write name: ");
        name = Console.ReadLine();

        Console.WriteLine("Your age: ");
        age = int.Parse(Console.ReadLine());

        Console.WriteLine("Height: ");
        height = float.Parse(Console.ReadLine());

        Console.WriteLine("Gender: ");
        gender = Console.ReadLine()[0];

        int days = age * 365;
        Console.WriteLine(name + " " + age + "y.o. " + height + " cm " + " " + gender + " " + days + " days you have lived. ");

 
    

    }
}
