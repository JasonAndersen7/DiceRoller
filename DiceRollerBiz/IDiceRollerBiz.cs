using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceRollerModels;
namespace DiceRollerBizComponent
{
    public interface IDiceRollerBiz
    {
        /// <summary>
        /// default method to roll two dice
        /// </summary>
        /// <param name="max">the number of sides the dice have, or the maximum value</param>
        /// <returns></returns>
        Die RollTwoDice(int max);

        /// <summary>
        /// Allows users to roll any number of dice
        /// </summary>
        /// <param name="d">the die object containing any number of dice</param>
        /// <returns></returns>
        /// <remarks>Not handled by the UI yet. </remarks>
        Die RollDice(Die d);
    }
}
