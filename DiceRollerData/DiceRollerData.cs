using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceRollerModels;
using Logging;

namespace DiceRollerData
{
    public class DiceRollerData : IDiceRollerData
    {
        #region properties
       
        #endregion

        #region public methods

        /// <summary>
        /// default method for rolling two dice
        /// </summary>
        /// <returns></returns>
        public Die RollTwoDice(int max)
        {
            //initialize the object 
            Die die = new Die(max);

            try
            {
              
                //assume that the dice are 6 sided
                die[0].CurrentRollValue = getRandomNumber(die[0]);
                die[1].CurrentRollValue = getRandomNumber(die[1]);
                
                die.totalRollValue = die[0].CurrentRollValue + die[1].CurrentRollValue;

                return die;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Method that can be used to roll any number of dice
        /// </summary>
        /// <param name="die"></param>
        /// <returns></returns>
        public Die RollDice(Die die)
        {
            try
            {
           
                foreach (var dice in die)
                {
                    dice.CurrentRollValue = getRandomNumber(dice);
                    die.totalRollValue += dice.CurrentRollValue;
                }

                return die;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        #endregion

        #region private methods

        /// <summary>
        /// Handles getting a random number
        /// </summary>
        /// <remarks> Future enhancement would be to research more random libraries</remarks>
        /// <param name="dice"></param>
        /// <returns></returns>
        private int getRandomNumber(Dice dice)
        {
           
            //add one to the max value, so it will incorporate that max value into the results
            int result = new Random().Next(dice.MinValue, dice.MaxValue + 1);
            Logger.LogMessage(String.Format("Dice rolled result: {0}", result), "Debug");
            return result;

        }

        #endregion
    }
}
