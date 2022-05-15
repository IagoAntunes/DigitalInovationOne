using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Inovation_One.Desafios_Iniciais
{
    public class Esfera
    {
        static void Esferas(string[] args)
        {
            double pi, raio, volume;
            pi = 3.14159;
            //TODO: Complete os espaços em branco com uma possível solução para o desafio     
            raio = double.Parse(Console.ReadLine());
            volume = pi * (4 / 3.0) * Math.Pow(raio, 3);
            volume = Math.Round(volume);
            Console.WriteLine("VOLUME = {0} ", volume);
        }
    }
}
