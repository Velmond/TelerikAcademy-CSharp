namespace PokerTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;
    using System;
    using System.Collections.Generic;

    [TestClass]
    public class HandTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void HandConstructorNullCardsTest()
        {
            ICard[] cards = null;
            IHand hand = new Hand(cards);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void HandConstructorNoCardsTest()
        {
            ICard[] cards = new ICard[0];
            IHand hand = new Hand(cards);
        }

        [TestMethod]
        public void HandToStringTest()
        {
            ICard[] cards = new ICard[5]
            {
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Diamonds)
            };

            IHand hand = new Hand(cards);
            string result = hand.ToString();
            string expected = "Two of Hearts, Five of Diamonds, Nine of Spades, Jack of Clubs, Ace of Diamonds";
            Assert.AreEqual(expected, result, "Hand.ToString() returns incorrect result.");
        }

        [TestMethod]
        public void HandToStringSameCardsTest()
        {
            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Spades)
            });

            string result = hand.ToString();
            string expected = "Ace of Spades, Ace of Spades, Ace of Spades, Ace of Spades, Ace of Spades";
            Assert.AreEqual(expected, result, "Hand.ToString() for a hand with the same cards returns incorrect result.");
        }
    }
}
