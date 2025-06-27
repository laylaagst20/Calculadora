using System.Runtime.CompilerServices;
using ExerciciosCsharp;


internal class Program
{
    private static void Main(string[] args)
    {
        Calculadora Calc = new Calculadora();
        Console.WriteLine($"Digite o Primeiro Número a calcular");
        int X = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Digite o Segundo Número a calcular");
        int Y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Escolha a Operação: (+,-,*,/)");
        string? Operacao = Console.ReadLine();

        switch (Operacao)
        {
            case "+":
                Calc.Somar(X, Y);
                break;
            case "-":
                Calc.Subtrair(X, Y);
                break;
            case "*":
                Calc.Multiplicar(X, Y);
                break;
            case "/":
                if (Y == 0)
                    {
                    Console.WriteLine($"Não é possivel dividir por 0");
                    }
                else
                    {
                    Calc.Dividr(X, Y);
                    }
                break;
            default:
                Console.WriteLine("Operação inválida.");
                break;
        }
    }

}