namespace AcademyPopcorn
{
    //05. Implement a TrailObject class. It should inherit the GameObject class and should have a constructor which takes
    //    an additional "lifetime" integer. The TrailObject should disappear after a "lifetime" amount of turns. You must
    //    NOT edit any existing .cs file. Then test the TrailObject by adding an instance of it in the engine through the
    //    AcademyPopcornMain.cs file.
    //========================================================================================================== Task 05>
    class TrailObject : GameObject
    {
        public new const string CollisionGroupString = "trail";
        private const char Symbol = '*';
        private int lifetime;

        public int Lifetime
        {
            get { return this.lifetime; }
            set { this.lifetime = value; }
        }

        public TrailObject(MatrixCoords topLeft, int lifetime)
            : base(topLeft, new char[,] { { TrailObject.Symbol } })
        {
            this.Lifetime = lifetime;
        }

        public override void Update()
        {
            this.Lifetime--;

            if (this.Lifetime == 0)
            {
                this.IsDestroyed = true;
            }
        }
    }
    //========================================================================================================== >Task 05
}
