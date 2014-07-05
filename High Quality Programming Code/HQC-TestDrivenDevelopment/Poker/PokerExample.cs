using System;
using System.Collections.Generic;

namespace Poker
{
    class PokerExample
    {
        static void Main()
        {
            ICard card = new Card(CardFace.Ace, CardSuit.Clubs);
            Console.WriteLine(card);

            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });
            Console.WriteLine(hand);

            IPokerHandsChecker checker = new PokerHandsChecker();
            Console.WriteLine(checker.IsValidHand(hand));
            Console.WriteLine(checker.IsOnePair(hand));
            Console.WriteLine(checker.IsTwoPair(hand));

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

            PokerHandsChecker handsChecker = new PokerHandsChecker();
            IHand firstHand = new Hand(firstCardsSet);
            IHand secondHand = new Hand(secondCardsSet);
            int result = handsChecker.CompareHands(firstHand, secondHand);
            Console.WriteLine(result);
        }
    }
}
