using System;
namespace Poker
{
    public class Card : ICard
    {
        private CardFace face;
        private CardSuit suit;

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public CardFace Face
        {
            get
            {
                return this.face;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Card face cannot be null.");
                }

                this.face = value;
            }
        }

        public CardSuit Suit
        {
            get
            {
                return this.suit;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Card suit cannot be null.");
                }

                this.suit = value;
            }
        }

        public override string ToString()
        {
            return this.Face.ToString() + " of " + this.suit.ToString();
        }

        public int CompareTo(ICard other)
        {
            int result = this.Face.CompareTo(other.Face);

            if (result == 0)
            {
                result = this.Suit.CompareTo(other.Suit);
            }

            return result;
        }

        public override bool Equals(object obj)
        {
            ICard other = (ICard)obj;
            return this.Face == other.Face && this.Suit == other.Suit;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}