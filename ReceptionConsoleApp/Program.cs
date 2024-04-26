using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("First name:");
        string FirstName = Console.ReadLine();

        Console.WriteLine("Last name:");
        string LastName = Console.ReadLine();

        Console.WriteLine("Your age:");
        int Age = Convert.ToInt32(Console.ReadLine());

        //Type your own file path.
        string fileLocation = "D:\\Visual Studio Projects\\ReceptionConsoleApp\\ReceptionConsoleApp\\Logs.txt";

        using (StreamWriter writer = new StreamWriter(fileLocation, true))
        {
            writer.WriteLine($"FirstName: {FirstName}  LastName: {LastName}  Age: {Age}");
        }

        Console.WriteLine("Datas saved to file.");
        Console.ReadLine();
    }
}
