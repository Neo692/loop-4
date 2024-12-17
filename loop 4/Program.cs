using System;

namespace upg4;

class Program
{
    static void Main(string[] args)
    {
        string password;

        do
        {
            Console.Write("Ange lösenord: ");
            password = Console.ReadLine();
        }
        while (password != "hemligt");

        Console.WriteLine("Rätt lösenord. Du är inloggad.");
    }
}
