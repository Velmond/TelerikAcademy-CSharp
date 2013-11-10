namespace AcademyPopcorn
{
    //========================================================================================================== Task 13>
    class Bullet : MovingObject
    {
        private const char Symbol = '^';
        
        public Bullet(MatrixCoords topLeft)
            : base(topLeft, body: new char[,] { { Bullet.Symbol } }, speed: new MatrixCoords(-1, 0))
        { }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "block" || otherCollisionGroupString == "unpassableBlock" ||
                   otherCollisionGroupString == "indestructibleBlock";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }

        public override string GetCollisionGroupString()
        {
            return Ball.CollisionGroupString;
        }
    }
    //========================================================================================================== >Task 13
}
