using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;


namespace BlackJack.Lib.UnitTests
{
    [TestClass]
    public class CardStackTests
    {
        [TestMethod]
        public void CardStack_SeeIfThereAreEnoughCards_Returns()
        {
            // Arrange
            int expectedNumberOfCards = 
            // Act
            CardStack stack = new CardStack();
            // Assert
            Assert.AreEqual(312, stack.Cards.Count); // 6 decks of 52 cards in a
            
        }
    }
}
