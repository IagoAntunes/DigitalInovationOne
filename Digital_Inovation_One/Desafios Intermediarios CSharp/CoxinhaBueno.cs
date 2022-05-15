using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Inovation_One.Desafios_Intermediarios_CSharp
{
    public class CoxinhaBueno
    {
        static void Coxinha()
        {
            string[] line = Console.ReadLine().Split();
            double X = double.Parse(line[0]);
            double Y = double.Parse(line[1]);
            Console.WriteLine("{0:f2}", X / Y);
        }
    }
}
