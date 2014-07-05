namespace Poker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PokerHandsChecker : IPokerHandsChecker
    {
        public const int HandSize = 5;

        public bool IsValidHand(IHand hand)
        {
            if (hand == null)
            {
                return false;
            }

            if (hand.Cards.Count != HandSize)
            {
                return false;
            }

            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Equals(hand.Cards[j]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            bool flush = this.IsStraight(hand);
            bool straight = this.IsFlush(hand);

            if (straight && flush)
            {
                return true;
            }

            return false;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            var orderedCards = this.OrderCards(hand);

            if (orderedCards[0].Value == 4)
            {
                return true;
            }

            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            var orderedCards = this.OrderCards(hand);

            if (orderedCards[0].Value == 3 && orderedCards[1].Value == 2)
            {
                return true;
            }

            return false;
        }

        public bool IsFlush(IHand hand)
        {
            IList<ICard> cards = hand.Cards;

            for (int i = 1; i < cards.Count; i++)
            {
                if (cards[0].Suit != cards[i].Suit)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsStraight(IHand hand)
        {
            hand.Sort();

            if ((hand.Cards[4].Face - hand.Cards[0].Face) == 4)
            {
                return true;
            }

            if (hand.Cards[4].Face == CardFace.Ace && hand.Cards[3].Face == CardFace.Five)
            {
                return true;
            }

            return false;
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            var orderedCards = this.OrderCards(hand);

            if (orderedCards[0].Value == 3 && orderedCards[1].Value == 1)
            {
                return true;
            }

            return false;
        }

        public bool IsTwoPair(IHand hand)
        {
            var orderedCards = this.OrderCards(hand);

            if (orderedCards[0].Value == 2 && orderedCards[1].Value == 2)
            {
                return true;
            }

            return false;
        }

        public bool IsOnePair(IHand hand)
        {
            var orderedCards = this.OrderCards(hand);

            if (orderedCards[0].Value == 2 && orderedCards[1].Value == 1 && orderedCards[2].Value == 1)
            {
                return true;
            }

            return false;
        }

        public bool IsHighCard(IHand hand)
        {
            return true;    // If the hand is not any of the ones it only qualifies as a high card hand (I think)
        }

        /// <summary>
        /// Compares the strenght of two hands
        /// </summary>
        /// <param name="firstHand">First hand to compare</param>
        /// <param name="secondHand">Hand to compare to firstHand</param>
        /// <returns>1 for first hand win, -1 for first hand lose, 0 for equal hands</returns>
        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            if (IsValidHand(firstHand) && IsValidHand(secondHand))
            {
                int firstHandStrenght = GetHandStrenght(firstHand);
                int secondHandStrenght = GetHandStrenght(secondHand);

                if (firstHandStrenght == secondHandStrenght && firstHandStrenght != 0)
                {
                    return CompaireHighCard(firstHand, secondHand);
                }
                else
                {
                    return firstHandStrenght.CompareTo(secondHandStrenght);
                }
            }
            else
            {
                throw new ArgumentException("One (or both) of the hands you are trying to compaire is invalid.");
            }
        }

        private int GetHandStrenght(IHand hand)
        {
            if (IsStraightFlush(hand))
            {
                return 8;
            }
            else if (IsFourOfAKind(hand))
            {
                return 7;
            }
            else if (IsFullHouse(hand))
            {
                return 6;
            }
            else if (IsFlush(hand))
            {
                return 5;
            }
            else if (IsStraight(hand))
            {
                return 4;
            }
            else if (IsThreeOfAKind(hand))
            {
                return 3;
            }
            else if (IsTwoPair(hand))
            {
                return 2;
            }
            else if (IsOnePair(hand))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private int CompaireHighCard(IHand firstHand, IHand secondHand)
        {
            var firstOrderedHand = OrderCards(firstHand);
            var secondOrderedHand = OrderCards(secondHand);

            return secondOrderedHand[5].Key.CompareTo(firstOrderedHand[5].Key);
        }

        private KeyValuePair<CardFace, int>[] OrderCards(IHand hand)
        {
            hand.Sort();

            Dictionary<CardFace, int> arrangedCards = new Dictionary<CardFace, int>();

            foreach (CardFace face in Enum.GetValues(typeof(CardFace)))
            {
                arrangedCards[face] = 0;
            }

            foreach (ICard card in hand.Cards)
            {
                arrangedCards[card.Face]++;
            }

            return arrangedCards.OrderByDescending(x => x.Value).ToArray();
        }
    }
}
