using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerLogic
{
    public class DiceRoller
    {
        public int RollDice(int sides = 6)
        {
            return new Random().Next(1, sides + 1);
        }
    }
}


