using Digital_Inovation_One.Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_CSharp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Inovation_One.Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_CSharp
{
    public class Program
    {
        static void Main()
        {
            int opc =0;
            List<Hero> ListaHerois = new List<Hero>();
            //Menu para criação do Heroi

            do
            {
                Console.WriteLine("[1]Criar Heroi\n[2]Exibir Herois\n[3]Sair\nR..");
                int escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        ListaHerois.Add(CriarHeroi());
                        break;
                    case 2:
                        ExibirHerois(ListaHerois);
                        break;
                    case 3:
                        Console.WriteLine("Saindo...");
                        break;
                }
            } while (opc != 3);


            Hero hero = new Hero("Arus",2,"Knight");
            Wizard wizard = new Wizard("Maleficus",99,"Devil");

            Console.WriteLine(hero.Attack());
            Console.WriteLine(wizard.Attack());

            Console.ReadLine();
        }
        static Hero CriarHeroi()
        {
            Console.WriteLine("Nome");
            string Nome = Console.ReadLine();

            Console.WriteLine("Level");
            int Level = int.Parse(Console.ReadLine());

            Console.WriteLine("Tipo");
            string Tipo = Console.ReadLine();

            var hero = new Hero(Nome, Level, Tipo);

            return hero;
        }
    
        static void ExibirHerois(List<Hero> ListaHerois)
        {
            foreach(var hero in ListaHerois)
            {
                Console.WriteLine(hero.ToString());
            } 
        }
    
    }
}
