using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Inovation_One.Desafios_Iniciais
{
    public class Polignos
    {
        static void Poligno(string[] args)
        {
            //TODO: Complete os espaços em branco com uma possível solução para o desafio
            string[] v = Console.ReadLine().Split();
            Console.WriteLine(int.Parse(v[0]) * int.Parse(v[1]));
        }
    }
}
