using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assigment_4.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Football;

namespace Assigment_4.Managers.Tests
{
    [TestClass()]
    public class FootballPlayersManagerTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            //Arrange
            FootballPlayersManager _manager = new FootballPlayersManager();
            //Act
            int result = _manager.GetAll().Count;
            //Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            //Arrange
            FootballPlayersManager _manager = new FootballPlayersManager();
            FootballPlayer player1 = _manager.GetById(1);
            //Act
            //Assert
            Assert.AreEqual(1, player1.Id);
            Assert.AreEqual(7, player1.ShirtNumber);
        }
    }
}