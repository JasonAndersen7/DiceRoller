using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceRollerModels;
using Logging;

namespace DiceRollerDataComponent
{

    /// <summary>
    /// This class handles the creation of psuedo random numbers, to be used for dice rolls 
    /// and to calculate the total value of the dice roll. 
    /// </summary>
    public class DiceRollerData : IDiceRollerData
    {
        #region properties
       
        #endregion

        #region public methods

        /// <summary>
        /// default method for rolling two dice
        /// </summary>
        /// <returns>The Die object which defaults to 2 dice, their Id, current roll value and 
        /// the number of sides the dice has</returns>
        public Die RollTwoDice(int max)
        {
            //initialize the object 
            Die die = new Die(max);

            try
            {
                //sanity check to verify the objects exist
                if (die[0] != null && die[1] != null)
                {
                    die[0].CurrentRollValue = getRandomNumber(die[0]);

                    die[1].CurrentRollValue = getRandomNumber(die[1]);

                    Logger.LogMessage(string.Format("Dice 1 roll result: {0} ", die[0].CurrentRollValue), "Debug");
                    Logger.LogMessage(string.Format("Dice 2 roll result: {0} ", die[1].CurrentRollValue), "Debug");

                    die.totalRollValue = die[0].CurrentRollValue + die[1].CurrentRollValue;

                    Logger.LogMessage(string.Format("Total dice roll result: {0} ", die.totalRollValue), "Debug");

                    return die; 
                }
                else
                {
                    Logger.LogMessage("One or more of the dice were not correctly instantiated" + DateTime.Now.ToLocalTime(), "Error");
                    throw new Exception("One or more of the dice were not correctly instantiated");
                }
            }
            catch (Exception ex)
            {
                Logger.LogMessage(string.Format("An error occurred {0} at {1}", ex.Message, DateTime.Now.ToLocalTime()), "Error");
                throw ex;
            }
        }

        /// <summary>
        /// Method that can be used to roll any number of dice
        /// </summary>
        /// <param name="die"></param>
        /// <returns></returns>
        /// <remarks> to be used for future functionality, allows users to pick how many dice to roll</remarks>
        public Die RollDice(Die die)
        {
            try
            {
                foreach (var dice in die)
                {
                    dice.CurrentRollValue = getRandomNumber(dice);
                    die.totalRollValue += dice.CurrentRollValue;
                    Logger.LogMessage(string.Format("Dice 1 roll result: {0}", dice.CurrentRollValue, DateTime.Now.ToLocalTime()), "Debug");
                }
                Logger.LogMessage(string.Format("Total dice roll result: {0} ", die.totalRollValue, DateTime.Now.ToLocalTime()), "Debug");

                return die;
            }
            catch (Exception ex)
            {
                Logger.LogMessage(string.Format("An error occurred {0} at {1}", ex.Message, DateTime.Now.ToLocalTime()), "Error");
                throw ex;
            }

        }

        #endregion

        #region private methods

        /// <summary>
        /// Handles getting a random number
        /// </summary>
        /// <remarks> Future enhancement would be to research more random libraries like RandomNumberGenerator</remarks>
        /// <param name="dice"></param>
        /// <returns></returns>
        private int getRandomNumber(Dice dice)
        {

            //add one to the max value, so it will incorporate that max value into the results
            //from experience you need to create a new Random object every time 
            //see http://csharpindepth.com/Articles/Chapter12/Random.aspx
            //and http://stackoverflow.com/questions/2706500/how-do-i-generate-a-random-int-number-in-c
            //
            int result = new Random().Next(dice.MinValue, dice.MaxValue + 1);
            Logger.LogMessage(String.Format("Dice rolled result: {0}", result), "Debug");
            return result;

        }

        #endregion
    }
}
