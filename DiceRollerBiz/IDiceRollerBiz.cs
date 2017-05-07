using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceRollerModels;
namespace DiceRollerBiz
{
    public interface IDiceRollerBiz
    {
        Die RollTwoDice(int max);

        Die RollDice(Die d);
    }
}
