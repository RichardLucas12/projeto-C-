using System;

namespace projeto_C_
{
    class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Digite um numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero");
            int num2 = int.Parse(Console.ReadLine());
            int result = num1 + num2;
            Console.WriteLine("resultado = "+ result + " seu burro");
        }
    }
}
