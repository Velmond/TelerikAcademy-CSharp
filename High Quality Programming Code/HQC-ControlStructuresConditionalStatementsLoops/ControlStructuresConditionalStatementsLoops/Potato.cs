namespace Cook
{
    public class Potato : Vegetable
    {
        //...
        private bool isPeeled;
        private bool isRotten;

        public bool IsPeeled
        {
            get
            {
                return this.isPeeled;
            }
            set
            {
                this.isPeeled = value;
            }
        }

        public bool IsRotten
        {
            get
            {
                return this.isRotten;
            }
            set
            {
                this.isRotten = value;
            }
        }
    }
}
