using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BlackJack.Lib.Tests
{
    [TestClass]
    public class CardStackTests
    {
        [TestMethod]
        public void Card_TestingTheAmountOfCards_Return312Cards()
        {
            // Arrange
            int expectedNumberOfCards = 312;
            // Act
            CardStack stack = new CardStack();
            // Assert
            Assert.AreEqual(expectedNumberOfCards, stack.Cards.Count); 


        }
    }
}
