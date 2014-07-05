namespace Poker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Hand : IHand
    {
        private IList<ICard> cards;

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
            this.Sort();
        }

        public IList<ICard> Cards
        {
            get
            {
                return this.cards;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("cards", "Cards cannot be null.");
                }

                if (value.Count < 5)
                {
                    throw new ArgumentException("cards", "Hand cand have less than five cards.");
                }

                this.cards = value;
            }
        }

        public void Sort()
        {
            this.Cards = this.Cards.
                OrderBy(card => (int)card.Face).
                ThenBy(card => (int)card.Suit).
                ToList();
        }

        public override string ToString()
        {
            return string.Join<ICard>(", ", this.Cards);
        }
    }
}