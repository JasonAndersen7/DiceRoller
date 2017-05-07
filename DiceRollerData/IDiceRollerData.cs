using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceRollerModels;
namespace DiceRollerData
{
    public interface IDiceRollerData
    {

        Die RollTwoDice(int max);

        Die RollDice(Die d);

    }
}
