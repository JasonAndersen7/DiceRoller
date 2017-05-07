using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerModels
{
   

    //container class for list of dice
    public class Die : List<Dice>
    {
        /// <summary>
        /// TODO: move to a config or parameter later
        /// </summary>
        private readonly int maxValue = 6;

        //not a great name, its the value of all the dice rolls
        public int totalRollValue { get; set; }

        //default contstructor will create two dice
        public Die ()
        {
            this.Add(new Dice(maxValue, 1));
            this.Add(new Dice(maxValue, 2));
        }


        public Die(int maxValue)
        {
            this.Add(new Dice(maxValue, 1));
            this.Add(new Dice(maxValue, 2));
        }
        ///// <summary>
        ///// use this constructor if you want to choose more than 2 dice, with a limit of 10 arbitrary
        ///// </summary>
        ///// <param name="numberOfDice"></param>
        //public Die(int numberOfDice)
        //{

        //    if (numberOfDice < 11)
        //    {
        //        for (int i = 0; i < numberOfDice; i++)
        //        {
        //            this.Add(new Dice());
        //        }
        //    }
        //    else
        //        throw new Exception("More than 10 dice were selected");

        //}


    }

}
