using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opgave1UnitTestPeter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1UnitTestPeter.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        [TestMethod()]
        public void IdTest()
        {
            FootballPlayer fbPlayer = new FootballPlayer();
            fbPlayer.Id = 1;
            Assert.AreEqual(1, fbPlayer.Id);
            //
        }

        [TestMethod()]
        public void NameTest()
        {
            FootballPlayer fbPlayer = new FootballPlayer();
            //fbPlayer.Name = "Bo";
            fbPlayer.Name = "Freddy";
            Assert.AreEqual("Freddy", fbPlayer.Name);
            Assert.ThrowsException<ArgumentException>(
                () => fbPlayer.Name = "Bo");

        }

        [TestMethod()]
        public void PriceTest()
        {
            FootballPlayer fbplayer = new FootballPlayer();
            fbplayer.Price = 1000;
            Assert.AreEqual(1000, fbplayer.Price);
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => fbplayer.Price = -1000);


        }

        [TestMethod()]
        public void ShirtNumberTest()
        {
            FootballPlayer fbplayer = new FootballPlayer();
            fbplayer.ShirtNumber = 24;
            Assert.AreEqual(24, fbplayer.ShirtNumber);
            Assert.ThrowsException<ArgumentException>(
                () => fbplayer.ShirtNumber = -10);

        }
    }
}