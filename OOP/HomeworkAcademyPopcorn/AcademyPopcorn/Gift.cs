namespace AcademyPopcorn
{
    using System.Collections.Generic;

    //11. Implement a Gift class. It should be a moving object, which always falls down.
    //    The gift shouldn't collide with any ball, but should collide (and be destroyed)
    //    with the racket. You must NOT edit any existing .cs file. 
    //========================================================================================================== Task 11>
    class Gift : MovingObject
    {
        private const char Symbol = 'g';

        public Gift(MatrixCoords topLeft)
            : base(topLeft, body: new char[,] { { Gift.Symbol } }, speed: new MatrixCoords(1, 0))
        { }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> producedObjects = new List<GameObject>();

            if (this.IsDestroyed)
            {
                producedObjects.Add(new ShootingRacket(new MatrixCoords(TopLeft.Row + 1, TopLeft.Col), 6)); 
            }

            return producedObjects;
        }
    }
    //========================================================================================================== >Task 11
}
