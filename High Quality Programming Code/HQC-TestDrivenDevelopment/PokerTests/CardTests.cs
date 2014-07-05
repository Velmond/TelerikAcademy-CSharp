namespace PokerTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;

    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void CardToStringSevenDiamondsTest()
        {
            Card card = new Card(CardFace.Seven, CardSuit.Diamonds);
            string result = card.ToString();
            string expexted = "Seven of Diamonds";
            Assert.AreEqual(expexted, result, "Card.ToString() returns incorrect result.");
        }

        [TestMethod]
        public void CardToStringAceHeartsTest()
        {
            Card card = new Card(CardFace.Ace, CardSuit.Hearts);
            string result = card.ToString();
            string expexted = "Ace of Hearts";
            Assert.AreEqual(expexted, result, "Card.ToString() returns incorrect result.");
        }

        [TestMethod]
        public void CardToStringTwoClubsTest()
        {
            Card card = new Card(CardFace.Two, CardSuit.Clubs);
            string result = card.ToString();
            string expexted = "Two of Clubs";
            Assert.AreEqual(expexted, result, "Card.ToString() returns incorrect result.");
        }

        [TestMethod]
        public void CardToStringQueenSpadesTest()
        {
            Card card = new Card(CardFace.Queen, CardSuit.Spades);
            string result = card.ToString();
            string expexted = "Queen of Spades";
            Assert.AreEqual(expexted, result, "Card.ToString() returns incorrect result.");
        }

        [TestMethod]
        public void CardCompairToEqualCardsTest()
        {
            Card firstCard = new Card(CardFace.Queen, CardSuit.Spades);
            Card secondCard = new Card(CardFace.Queen, CardSuit.Spades);
            int result = firstCard.CompareTo(secondCard);
            int expexted = 0;
            Assert.AreEqual(expexted, result, "Compairing equal cards returns they are not equal.");
        }

        [TestMethod]
        public void CardCompairToStrongerToWeakerCardsTest()
        {
            Card firstCard = new Card(CardFace.Queen, CardSuit.Spades);
            Card secondCard = new Card(CardFace.Five, CardSuit.Hearts);
            int result = firstCard.CompareTo(secondCard);
            int expexted = 1;
            Assert.AreEqual(expexted, result, "Compairing stronger to weaker card returns wrong result.");
        }

        [TestMethod]
        public void CardCompairToWeakerToStrongerCardsTest()
        {
            Card firstCard = new Card(CardFace.Three, CardSuit.Diamonds);
            Card secondCard = new Card(CardFace.Five, CardSuit.Hearts);
            int result = firstCard.CompareTo(secondCard);
            int expexted = -1;
            Assert.AreEqual(expexted, result, "Compairing weaker to stronger card returns wrong result.");
        }
    }
}
