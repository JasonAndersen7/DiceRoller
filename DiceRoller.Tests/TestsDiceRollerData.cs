using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiceRollerDataComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DiceRollerDataComponent.Tests
{

    /// <summary>
    /// Testing classes to test the Data layer and creation of the dice rolls. 
    /// One could argue that these are more integration than unit tests.
    /// </summary>
    [TestClass()]
    public class TestsDiceRollerData
    {
        /// <summary>
        /// Default Test method to see if rolling the 6 sided dice yields a correct result
        /// </summary>
        [TestMethod()]
        public void TestRollTwoDice()
        {
            //arrange
            var testDiceRoller = new DiceRollerData();

            //act
            var result = testDiceRoller.RollTwoDice(6);

            //assert
            Assert.IsTrue(result.totalRollValue > 1 && result.totalRollValue <= 12);

        }

        /// <summary>
        /// Default Test method to see if rolling the 8 sided dice yields a correct result
        /// </summary>
        [TestMethod()]
        public void TestRollTwoDice8sided()
        {
            //arrange
            var testDiceRoller = new DiceRollerData();

            //act
            var result = testDiceRoller.RollTwoDice(8);

            //assert
            Assert.IsTrue(result.totalRollValue > 1 && result.totalRollValue <= 16);

        }


        /// <summary>
        ///  Default Test method to see if rolling a 12 sided dice yields a correct result
        /// </summary>
        [TestMethod()]
        public void TestRollTwoDice12sided()
        {
            //arrange
            var testDiceRoller = new DiceRollerData();

            //act
            var result = testDiceRoller.RollTwoDice(12);

            //assert
            Assert.IsTrue(result.totalRollValue > 1 && result.totalRollValue <= 24);

        }

    }
}