using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossFight
{
    internal class Boss : GameCharacter
    {
        public Boss()
        {
            Name = "Boss";
            Health = 300;
            Stamina = 10;
            MaxStamina = 10;
            Recharging = @$"{Name} is recharging, better be careful.";
        }
    }
}
