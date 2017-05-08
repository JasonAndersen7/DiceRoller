using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerModels
{

    /// <summary>
    /// container class for list of dice, defaults to 2 dice
    /// </summary>
    public class Die : List<Dice>
    {
        /// <summary>
        /// TODO: move to a config or parameter later
        /// </summary>
        private readonly int maxValue = 6;

        //the value of all the dice rolls, i.e. dice 1 rolls '3' and dice 2 rolls '4'
        //the total roll value is '7'
        public int totalRollValue { get; set; }

        //default contstructor will create two dice with 6 sides
        public Die ()
        {
            this.Add(new Dice(maxValue, 1));
            this.Add(new Dice(maxValue, 2));
        }

        /// <summary>
        /// Constructor to choose number of sides
        /// </summary>
        /// <param name="maxValue">number of sides, or maximum value</param>
        public Die(int maxValue)
        {
            this.Add(new Dice(maxValue, 1));
            this.Add(new Dice(maxValue, 2));
        }

    }

}
