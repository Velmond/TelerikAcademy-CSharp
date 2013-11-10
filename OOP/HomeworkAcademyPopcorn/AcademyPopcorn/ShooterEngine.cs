namespace AcademyPopcorn
{
    //04. Inherit the Engine class. Create a method ShootPlayerRacket. Leave it empty for now.
    //========================================================================================================== Task 04>

    class ShooterEngine : Engine
    {
        ShootingRacket racket;

        public ShooterEngine(IRenderer renderer, IUserInterface userInterface)
            : base(renderer, userInterface)
        {
            //this.racket = new ShootingRacket(topLeft, 6);
        }

        public ShooterEngine(IRenderer renderer, IUserInterface userInterface, int threadSleepTime)
            : base(renderer, userInterface, threadSleepTime)
        { }

        //13. Implement a shoot ability for the player racket. The ability should only be activated when a Gift
        //    object falls on the racket. The shot objects should be a new class (e.g. Bullet) and should destroy
        //    normal Block objects (and be destroyed on collision with any block).Use the engine and ShootPlayerRacket
        //    method you implemented in task 4, but don't add items in any of the engine lists through the ShootPlayerRacket
        //    method. Also don't edit the Racket.cs file.
        //    Hint: you should have a ShootingRacket class and override its ProduceObjects method.
        //===================================================================================================== Task 13>>
        public void ShootPlayerRacket()
        {
            if (this.racket is ShootingRacket)
            {
                this.racket.Shoot();
            }
        }

        public override void AddObject(GameObject obj)
        {
            ShootingRacket shootingRacket = obj as ShootingRacket;

            if (shootingRacket != null)
            {
                racket = shootingRacket;
            }

            base.AddObject(obj);
        }
    }
    //================================================================================================ >>Task 13 >Task 04
}
