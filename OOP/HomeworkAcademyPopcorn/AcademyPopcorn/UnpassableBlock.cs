namespace AcademyPopcorn
{
    //08.02. Implement an UnstoppableBall and an UnpassableBlock. The UnstopableBall only bounces off UnpassableBlocks
    //       and will destroy any other block it passes through. The UnpassableBlock should be indestructible.
    //       Hint: Take a look at the RespondToCollision method, the GetCollisionGroupString method and the CollisionData class.
    //========================================================================================================== Task 08>
    class UnpassableBlock : Block
    {
        public new const string CollisionGroupString = "unpassableBlock";
        private const char Symbol = 'X';

        public UnpassableBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
            this.body[0, 0] = UnpassableBlock.Symbol;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            // Do nothing
        }

        public override string GetCollisionGroupString()
        {
            return UnpassableBlock.CollisionGroupString;
        }
    }
    //========================================================================================================== >Task 08
}
