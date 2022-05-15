using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Inovation_One.Desafios_Iniciais
{
    public class Media2
    {
        static void Media(string[] args)
        {
            double A, B, C;
            double mediaP;
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());
            mediaP = ((A * 2) + (B * 3) + (C * 5)) / (2 + 3 + 5);
            Console.WriteLine("MEDIA = {0:f1}", mediaP);
            Console.ReadKey();
        }
    }
}
