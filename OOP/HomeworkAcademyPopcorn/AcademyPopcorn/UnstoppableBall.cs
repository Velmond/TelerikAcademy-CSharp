namespace AcademyPopcorn
{
    using System.Collections.Generic;

    //08.01. Implement an UnstoppableBall and an UnpassableBlock. The UnstopableBall only bounces off UnpassableBlocks
    //       and will destroy any other block it passes through. The UnpassableBlock should be indestructible.
    //       Hint: Take a look at the RespondToCollision method, the GetCollisionGroupString method and the CollisionData class.
    //========================================================================================================== Task 08>
    class UnstoppableBall : Ball
    {
        public new const string CollisionGroupString = "unstoppableBall";
        private const char Symbol = '@';

        public UnstoppableBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        {
            base.body[0, 0] = UnstoppableBall.Symbol;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket" || otherCollisionGroupString == "unpassableBlock" ||
                   otherCollisionGroupString == "block" || otherCollisionGroupString == "indestructibleBlock";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            List<string> collisionObjectsGroupStrings = collisionData.hitObjectsCollisionGroupStrings;

            foreach (var obj in collisionObjectsGroupStrings)
            {
                if (obj.Equals(UnpassableBlock.CollisionGroupString) || obj.Equals(Racket.CollisionGroupString) || 
                    obj.Equals(IndestructibleBlock.CollisionGroupString))
                {
                    base.RespondToCollision(collisionData);
                }
            }
        }

        public override string GetCollisionGroupString()
        {
            return UnstoppableBall.CollisionGroupString;
        }
    }
    //========================================================================================================== >Task 08
}
