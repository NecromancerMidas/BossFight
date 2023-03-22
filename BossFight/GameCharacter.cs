using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bossfight;

namespace BossFight
{
    internal class GameCharacter
    {
        protected string Name;
        protected int Health;
        protected int Strength;
        protected int Stamina;
        protected int MaxStamina;
        protected string Recharging = String.Empty;


        public void Fight(GameCharacter enemy)
        {
            if (Name != "Boss")
            {
                enemy.Health -= Strength;
                Stamina -= 10;
                if (enemy.Health <= 0)
                {
                    enemy.Health = 0;
                }
                Console.WriteLine(@$"{Name} hits {enemy.Name} for {Strength} damage, now {enemy.Name} has {enemy.Health} health left
");
            }
            else
            {
                Strength = Randomer.Randomizer(0, 30);
                enemy.Health -= Strength;
                Stamina -= 10;
                if (enemy.Health <= 0)
                {
                    enemy.Health = 0;
                }
                Console.WriteLine(
                    $@"{(Strength == 0 ? @$"{Name} completely misses like a noob." : @$"{Name} strikes {enemy.Name} for {Strength} damage, now {enemy.Name} has {enemy.Health} left.")}
");
            }
        }

        public void Recharge()
        {
            Stamina = MaxStamina;
            Console.WriteLine(Recharging);
        }
        public void Action(GameCharacter enemy)
        {
            if(Stamina <= 0)
            {
                Recharge();
            }
            else
            {
                Fight(enemy);
            }

        }
        public bool IsAlive()
        {
            if (Health <= 0)
            {              
                Console.WriteLine($"{Name} is dead");
                return false;
            }

          return true;
        }

    }
}
