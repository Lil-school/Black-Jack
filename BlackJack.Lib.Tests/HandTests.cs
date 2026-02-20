using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BlackJack.Lib.Tests
{
    [TestClass]
    public class HandTests
    {
        Hand _hand;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cardValues"></param>
        /// <param name="expectedValue"></param>
        [DataRow(new[] { CardValue.Ten, CardValue.Ace, CardValue.Queen }, 21)]
        [DataRow(new[] { CardValue.Seven, CardValue.Seven, CardValue.Ace }, 15)]
        [DataRow(new[] { CardValue.Ace, CardValue.Ace, CardValue.Ace }, 13)]
        [DataRow(new[] { CardValue.Ace, CardValue.Ace, CardValue.Ace, CardValue.Ace,CardValue.Ace }, 15)]
        [TestMethod]
        public void CalculateValue_ShouldCalculateTheCorrectValueDependingOnTheAce_CorrectValue(CardValue[] cardValues, int expectedValue)
        {
            // Arrange
            _hand = new Hand();
            foreach (var value in cardValues)
            {
                _hand.AddCard(Factory.CreateCard(CardSuit.Heart, value));
            }
            // Act
            int actualValue = _hand.CalculateValue();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        /// <summary>
        /// Verifies that the hand status is correctly set based on the values of the cards in the hand.
        /// </summary>
        /// <remarks>This test method uses data-driven tests to validate various hand scenarios, including
        /// BlackJack, Triple Seven, Five Card Charlie, and Busted states.</remarks>
        /// <param name="cardValues">An array of card values representing the cards in the hand, which influences the calculated hand status.</param>
        /// <param name="expectedStatus">The expected hand status that should result from the provided card values after calculation.</param>
        [DataRow(new[] { CardValue.Ace, CardValue.King }, HandStatus.BlackJack)]
        [DataRow(new[] { CardValue.Seven, CardValue.Seven, CardValue.Seven }, HandStatus.TripleSeven)]
        [DataRow(new[] { CardValue.Ace, CardValue.Two, CardValue.Three, CardValue.Four, CardValue.Ace }, HandStatus.FiveCardCharlie)]
        [DataRow(new[] { CardValue.Ten, CardValue.King, CardValue.Two }, HandStatus.Busted)]
        [TestMethod]
        public void UpdateStatus_ShouldSetStatusBasedOnHandValue(CardValue[] cardValues, HandStatus expectedStatus)
        {
            // Arrange
            _hand=new Hand();
            foreach (var value in cardValues)
            {
                _hand.AddCard(Factory.CreateCard(CardSuit.Club, value));
            }

            // Act
            _hand.CalculateValue();

            // Assert
            Assert.AreEqual(expectedStatus, _hand.Status);
        }

    }
}
