using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossFight
{
    internal class Hero : GameCharacter
    {
        public Hero()
        {
            Name = "Hero";
            Health = 100;
            Strength = 20;
            Stamina = 40;
            MaxStamina = 40;
            Recharging = @$"{Name} is resting, {Name} will be back in fighting shape soon.";
        }
    }
}
