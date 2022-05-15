using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Inovation_One.Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_CSharp.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + "Lançou um feitiço";
        }
        public string Attack(int bonus)
        {
            if(bonus > 6)
                return this.Name + "Lançou um feitiço com bonus de ataque de " + bonus;
            else
                return this.Name + "Lançou um feitiço Fraco com bonus de ataque de " + bonus;
        }
    }
}
