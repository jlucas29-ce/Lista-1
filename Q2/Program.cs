using System;

class Program
{
    static void Main()
    {
        double IMC, peso, altura;
        Console.WriteLine("Informe o seu peso :");
        double.TryParse(Console.ReadLine(), out peso);
         Console.WriteLine("Informe a sua altura :");
        double.TryParse(Console.ReadLine(), out altura);
        IMC = peso/Math.Pow(altura,2);
        Console.WriteLine($"O seu imc é igual a: {IMC}");
        Console.ReadLine(); 
    }
}
