namespace AcademyPopcorn
{
    //10.02. Implement an ExplodingBlock. It should destroy all blocks around it when it is destroyed.
    //       You must NOT edit any existing .cs file.
    //       Hint: what does an explosion "produce"?
    //========================================================================================================== Task 10>
    class ExplosionDebris : MovingObject
    {
        public ExplosionDebris(MatrixCoords topLeft)
            : base(topLeft, body: new char[,] { { '*' } }, speed: new MatrixCoords(0, 0))
        { }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "brick";
        }

        public override void Update()
        {
            base.Update();
            this.IsDestroyed = true;
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
    //========================================================================================================== >Task 10
}
