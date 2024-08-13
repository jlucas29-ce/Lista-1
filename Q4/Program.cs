using System;

class Program
{
    static void Main()
    {
        double feh, conver;
        Console.WriteLine("Informe a temperatura em  fahrenheit:");
        double.TryParse(Console.ReadLine(), out feh);
        conver =  ((feh - 32) * 5/9);
        Console.WriteLine($"A conversão para celsius {conver}");
        Console.ReadLine(); 
    }
}
