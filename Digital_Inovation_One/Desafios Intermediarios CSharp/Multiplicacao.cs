using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Inovation_One.Desafios_Intermediarios_CSharp
{
    internal class Multiplicacao
    {
        static void Multi(string[] args)
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("PROD = " + (a * b)); //implemente o código que representa a multiplicação.
            Console.ReadLine();
        }
    }
}
