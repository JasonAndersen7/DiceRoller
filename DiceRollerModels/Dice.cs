using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerModels
{
    /// <summary>
    /// Represents a single dice
    /// </summary>
    public class Dice
    {
        //All dice must have at least a minimum value of 1 
        public readonly int MinValue = 1;

        /// <summary>
        /// what is the maximum value this can have ?
        /// </summary>
        public int MaxValue { get; set; }

        //what is the current Roll that this dice has? 
        public int CurrentRollValue { get; set; }

        //the ID of the dice, 
        public int Id { get; set; }


        /// <summary>
        /// Default Constructor
        /// </summary>
        public Dice()
        {

        }

        /// <summary>
        /// Creates an instance of the Dice class that allows the user to pick the number of
        /// sides of the dice
        /// </summary>
        /// <param name="maxValue">the max value, 6, 8, 12 or 20 sided</param>
        public Dice(int maxValue)
        {
            this.MaxValue = maxValue;
        }

        /// <summary>
        /// Creates an instance of the Dice class that allows the user to pick the number of
        /// sides of the dice, and the Id of the dice
        /// </summary>
        /// <param name="maxValue">the max value, 6, 8, 12 or 20 sided</param>
        /// <param name="id">the id of the dice, 1, 2</param>
        public Dice(int maxValue, int id)
        {
            this.MaxValue = maxValue;
            this.Id = id;
        }

    }
}
