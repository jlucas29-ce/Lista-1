using System;

class Program
{
    static void Main()
    {
        double salario, rea;
        Console.WriteLine("Informe o seu salario:");
        double.TryParse(Console.ReadLine(), out salario);
        rea = salario * 1.2;
        Console.WriteLine($"O seu salario com reajuste: {rea}");
        Console.ReadLine(); 
    }
}

