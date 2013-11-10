namespace AcademyPopcorn
{
    using System.Collections.Generic;

    //10.01. Implement an ExplodingBlock. It should destroy all blocks around it when it is destroyed.
    //       You must NOT edit any existing .cs file.
    //       Hint: what does an explosion "produce"?
    //========================================================================================================== Task 10>
    class ExplodingBlock : Block
    {
        public static char Symbol = 'B';

        public ExplodingBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
            this.body[0, 0] = ExplodingBlock.Symbol;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> producedObjects = new List<GameObject>();

            if (this.IsDestroyed)
            {
                for (int row = this.TopLeft.Row - 1; row < this.TopLeft.Row + 2; row++)
                {
                    for (int col = this.TopLeft.Col - 1; col < this.TopLeft.Col + 2; col++)
                    {
                        if (col != this.TopLeft.Col || row != this.TopLeft.Row)
                        {
                            producedObjects.Add(new ExplosionDebris(new MatrixCoords(row, col)));
                        }
                    }
                }
            }

            return producedObjects;
        }
    }
    //========================================================================================================== >Task 10
}
