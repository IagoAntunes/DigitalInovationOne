using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Inovation_One.Desafios_Iniciais
{
    public class MaiorPosicao
    {
        static void Maior(string[] args)
        {
            //TODO: Complete os espaços em branco com uma possível solução para o desafio
            int n;
            int maior = 0;
            int posicao = 0;
            for (int i = 1; i <= 100; i++)
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n > maior)
                {
                    maior = n;
                    posicao = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }
    }
}
