namespace AcademyPopcorn
{
    using System.Collections.Generic;

    //12. Implement a GiftBlock class. It should be a block, which "drops" a Gift object when it is destroyed.
    //    You must NOT edit any existing .cs file. Test the Gift and GiftBlock classes by adding them through
    //    the AcademyPopcornMain.cs file.
    //========================================================================================================== Task 12>
    class GiftBlock : Block
    {
        private const char Symbol = 'G';

        public GiftBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
            this.body[0, 0] = GiftBlock.Symbol;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> giftsDropped = new List<GameObject>();

            if (this.IsDestroyed)
            {
                giftsDropped.Add(new Gift(this.TopLeft));
            }

            return giftsDropped;
        }
    }
    //========================================================================================================== Task 12>
}
