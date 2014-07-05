namespace PokerTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;
    using System.Collections.Generic;

    [TestClass]
    public class PokerHandCheckerTests
    {
        private static PokerHandsChecker handsChecker;

        [ClassInitialize]
        public static void InitializeHandChecker(TestContext context)
        {
            handsChecker = new PokerHandsChecker();
        }

        [TestMethod]
        public void PokerHandCheckerIsValidInvalidHandTest()
        {
            IList<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Clubs)
            };

            IHand hand = new Hand(cards);
            bool isValid = handsChecker.IsValidHand(hand);

            Assert.IsFalse(isValid, "Invalid hand is evaluated as valid.");
        }

        [TestMethod]
        public void PokerHandCheckerIsValidNullTest()
        {
            bool validHand = handsChecker.IsValidHand(null);
            Assert.IsFalse(validHand, "Null is evaluated as valid hand.");
        }

        [TestMethod]
        public void PokerHandCheckerIsValidValidHandTest()
        {
            IList<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Clubs)
            };

            IHand hand = new Hand(cards);
            bool isValid = handsChecker.IsValidHand(hand);

            Assert.IsTrue(isValid, "Valid hand is evaluated as invalid.");
        }

        [TestMethod]
        public void PokerHandCheckerIsStraightTrueTest()
        {
            IList<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Six, CardSuit.Hearts)
            };

            IHand hand = new Hand(cards);
            bool isStraight = handsChecker.IsStraight(hand);

            Assert.IsTrue(isStraight, "Straight hand is evaluated as not straight.");
        }

        [TestMethod]
        public void PokerHandCheckerIsStraightFalseTest()
        {
            IList<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Spades)
            };

            IHand hand = new Hand(cards);
            bool isStraight = handsChecker.IsStraight(hand);

            Assert.IsFalse(isStraight, "Non straight hand is evaluated as straight.");
        }

        [TestMethod]
        public void PokerHandCheckerIsFluchTrueTest()
        {
            IList<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Clubs)
            };

            IHand hand = new Hand(cards);
            bool isFlush = handsChecker.IsFlush(hand);

            Assert.IsTrue(isFlush, "Flush hand is evaluated as not flush.");
        }

        [TestMethod]
        public void PokerHandCheckerIsFluchFalseTest()
        {
            IList<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Clubs)
            };

            IHand hand = new Hand(cards);
            bool isFlush = handsChecker.IsFlush(hand);

            Assert.IsFalse(isFlush, "Non flush hand is evaluated as flush.");
        }

        [TestMethod]
        public void PokerHandCheckerIsStraightFluchTrueTest()
        {
            IList<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs)
            };

            IHand hand = new Hand(cards);
            bool isStraightFlush = handsChecker.IsStraightFlush(hand);

            Assert.IsTrue(isStraightFlush, "Straight flush hand is evaluated as not straight flush.");
        }

        [TestMethod]
        public void PokerHandCheckerIsStraightFluchFalseTest()
        {
            IList<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs)
            };

            IHand hand = new Hand(cards);
            bool isStraightFlush = handsChecker.IsStraightFlush(hand);

            Assert.IsFalse(isStraightFlush, "Non straight flush hand is evaluated as straight flush.");
        }

        [TestMethod]
        public void PokerHandCheckerIsFourOfKindTrueTest()
        {
            IList<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Clubs)
            };

            IHand hand = new Hand(cards);
            bool isFourOfKind = handsChecker.IsFourOfAKind(hand);

            Assert.IsTrue(isFourOfKind, "Four of a kind hand is evaluated as not four of a kind.");
        }

        [TestMethod]
        public void PokerHandCheckerIsFourOfKindFalseTest()
        {
            IList<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Diamonds)
            };

            IHand hand = new Hand(cards);
            bool isFourOfKind = handsChecker.IsFourOfAKind(hand);

            Assert.IsFalse(isFourOfKind, "Non four of a kind hand is evaluated as four of a kind.");
        }

        [TestMethod]
        public void PokerHandCheckerIsFullHouseTrueTest()
        {
            IList<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Spades)
            };

            IHand hand = new Hand(cards);
            bool isFullHouse = handsChecker.IsFullHouse(hand);

            Assert.IsTrue(isFullHouse, "Full house hand is evaluated as not full house.");
        }

        [TestMethod]
        public void PokerHandCheckerIsFullHouseFalseTest()
        {
            IList<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts)
            };

            IHand hand = new Hand(cards);
            bool isFullHouse = handsChecker.IsFullHouse(hand);

            Assert.IsFalse(isFullHouse, "Non full house hand is evaluated as full house.");
        }

        [TestMethod]
        public void PokerHandCheckerIsThreeOfAKindTrueTest()
        {
            IList<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts)
            };

            IHand hand = new Hand(cards);
            bool isThreeOfAKind = handsChecker.IsThreeOfAKind(hand);

            Assert.IsTrue(isThreeOfAKind, "Three of a kind hand is evaluated as not three of a kind.");
        }

        [TestMethod]
        public void PokerHandCheckerIsThreeOfAKindFalseTest()
        {
            IList<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts)
            };

            IHand hand = new Hand(cards);
            bool isThreeOfAKind = handsChecker.IsThreeOfAKind(hand);

            Assert.IsFalse(isThreeOfAKind, "Non three of a kind hand is evaluated as three of a kind.");
        }

        [TestMethod]
        public void PokerHandCheckerIsTwoPairTrueTest()
        {
            IList<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts)
            };

            IHand hand = new Hand(cards);
            bool isTwoPair = handsChecker.IsTwoPair(hand);

            Assert.IsTrue(isTwoPair, "Two pair hand is evaluated as not two pair.");
        }

        [TestMethod]
        public void PokerHandCheckerIsTwoPairFalseTest()
        {
            IList<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts)
            };

            IHand hand = new Hand(cards);
            bool isTwoPair = handsChecker.IsTwoPair(hand);

            Assert.IsFalse(isTwoPair, "Non two pair hand is evaluated as two pair.");
        }

        [TestMethod]
        public void PokerHandCheckerIsOnePairTrueTest()
        {
            IList<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts)
            };

            IHand hand = new Hand(cards);
            bool isOnePair = handsChecker.IsOnePair(hand);

            Assert.IsTrue(isOnePair, "One pair hand is evaluated as not one pair.");
        }

        [TestMethod]
        public void PokerHandCheckerIsOnePairFalseTest()
        {
            IList<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts)
            };

            IHand hand = new Hand(cards);
            bool isOnePair = handsChecker.IsOnePair(hand);

            Assert.IsFalse(isOnePair, "Non one pair hand is evaluated as one pair.");
        }

        [TestMethod]
        public void PokerHandCheckerCompareHandsEqualTest()
        {
            IList<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts)
            };

            IHand firstHand = new Hand(cards);
            IHand secondHand = new Hand(cards);
            int result = handsChecker.CompareHands(firstHand, secondHand);
            int expected = 0;

            Assert.AreEqual(expected, result, "Equal hands are evaluated as not equal.");
        }

        [TestMethod]
        public void PokerHandCheckerCompareHandsStrongerToWeakerTest()
        {
            IList<ICard> firstCardsSet = new List<ICard>()
            {
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs)
            };

            IList<ICard> secondCardsSet = new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts)
            };

            IHand firstHand = new Hand(firstCardsSet);
            IHand secondHand = new Hand(secondCardsSet);
            int result = handsChecker.CompareHands(firstHand, secondHand);
            int expected = 1;

            Assert.AreEqual(expected, result, "Stronger hand is incorrectly compared to weaker one.");
        }

        [TestMethod]
        public void PokerHandCheckerCompareHandsWeakerToStrongerTest()
        {
            IList<ICard> firstCardsSet = new List<ICard>()
            {
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Diamonds)
            };

            IList<ICard> secondCardsSet = new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts)
            };

            IHand firstHand = new Hand(firstCardsSet);
            IHand secondHand = new Hand(secondCardsSet);
            int result = handsChecker.CompareHands(firstHand, secondHand);
            int expected = -1;

            Assert.AreEqual(expected, result, "Weaker hand is incorrectly compared to stronger one.");
        }
    }
}
