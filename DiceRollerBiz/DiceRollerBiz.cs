using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceRollerData;
using DiceRollerModels;
namespace DiceRollerBiz
{
    public class DiceRollerBiz : IDiceRollerBiz
    {
        public Die RollTwoDice(int max)
        {

            IDiceRollerData diceRoller = new DiceRollerData.DiceRollerData();

            Die result = diceRoller.RollTwoDice(max);

            return result;

        }

        public Die RollDice(Die d)
        {
            IDiceRollerData diceRoller = new DiceRollerData.DiceRollerData();
            var result = diceRoller.RollDice(d);
            return result;

        }

    }
}
