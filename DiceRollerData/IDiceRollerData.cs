using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceRollerModels;
namespace DiceRollerDataComponent
{
    public interface IDiceRollerData
    {
        /// <summary>
        /// default method to roll two dice
        /// </summary>
        /// <param name="max">the number of sides of the dice</param>
        /// <returns></returns>
        Die RollTwoDice(int max);


        /// <summary>
        /// Future functionality to roll any number of dice
        /// </summary>
        /// <param name="d">the list of dice to roll </param>
        /// <returns></returns>
        Die RollDice(Die d);

    }
}
