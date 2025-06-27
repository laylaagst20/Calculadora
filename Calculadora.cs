using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosCsharp
{
    public class Calculadora
    {
        public void Somar(int X, int Y)
        {
            Console.WriteLine($"{X} + {Y} = {X + Y}");
        }

        public void Subtrair(int X, int Y)
        {
            Console.WriteLine($"{X} - {Y}= {X - Y}");
        }
        public void Multiplicar(int X, int Y)
        {
            Console.WriteLine($"{X} * {Y}= {X * Y}");
        }
        public void Dividr(int X, int Y)
        {
            Console.WriteLine($"{X} % {Y}= {X / Y}");
        }
    }
}