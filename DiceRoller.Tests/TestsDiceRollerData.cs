using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiceRollerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerData.Tests
{
    [TestClass()]
    public class TestsDiceRollerData
    {
        [TestMethod()]
        public void TestRollTwoDice()
        {
            //arrange
            var testDiceRoller = new DiceRollerData();


            //act
           var result =  testDiceRoller.RollTwoDice(6);

            //assert
            Assert.IsTrue(result.totalRollValue > 0 && result.totalRollValue <= 12);


        }
    }
}