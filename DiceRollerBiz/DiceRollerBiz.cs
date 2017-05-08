using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceRollerDataComponent;
using DiceRollerModels;

namespace DiceRollerBizComponent
{

    /// <summary>
    /// This class will handle any business logic pertaining to the rolling of dice. 
    /// if we wanted to add validation here or do logic, like getting doubles will let you roll again
    /// or get a prize for example. 
    /// </summary>
    public class DiceRollerBiz : IDiceRollerBiz
    {
        /// <summary>
        /// Default method to roll two dice
        /// </summary>
        /// <param name="max">the number of sides a dice has or its maximum value</param>
        /// <returns></returns>
        public Die RollTwoDice(int max)
        {

            IDiceRollerData diceRoller = new DiceRollerDataComponent.DiceRollerData();

            Die result = diceRoller.RollTwoDice(max);

            return result;

        }

        /// <summary>
        /// Allows users to pass in a list of dice to roll, 
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        /// <remarks>Not implemented on the User Interface yet. </remarks>
        public Die RollDice(Die d)
        {
            IDiceRollerData diceRoller = new DiceRollerDataComponent.DiceRollerData();
            var result = diceRoller.RollDice(d);
            return result;

        }

    }
}
