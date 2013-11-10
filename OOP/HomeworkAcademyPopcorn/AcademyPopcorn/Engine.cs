namespace AcademyPopcorn
{
    using System;
    using System.Collections.Generic;

    public class Engine
    {
        IRenderer renderer;
        IUserInterface userInterface;
        List<GameObject> allObjects;
        List<MovingObject> movingObjects;
        List<GameObject> staticObjects;
        Racket playerRacket;

        //02. The Engine class has a hardcoded sleep time (search for "System.Threading.Sleep(500)". Make the sleep
        //    time a field in the Engine and implement a constructor, which takes it as an additional parameter.
        //================================================================================================== Task 02>
        private int threadSleepTime;

        public int ThreadSleepTime
        {
            get
            {
                return this.threadSleepTime;
            }
            private set
            {
                if (value < 50)
                {
                    throw new ArgumentException("TreadSleapTime can't be less than 50.");
                }

                this.threadSleepTime = value;
            }
        }

        public Engine(IRenderer renderer, IUserInterface userInterface, int threadSleepTime)
            : this(renderer, userInterface)
        {
            this.ThreadSleepTime = threadSleepTime;
        }
        //================================================================================================== >Task 02

        public Engine(IRenderer renderer, IUserInterface userInterface)
        {
            this.renderer = renderer;
            this.userInterface = userInterface;
            this.allObjects = new List<GameObject>();
            this.movingObjects = new List<MovingObject>();
            this.staticObjects = new List<GameObject>();

            // Default thread sleep time if it is not specified in the constructor is set to 500
            //============================================================================================= Addition>
            this.ThreadSleepTime = 500;
            //============================================================================================= >Addition
        }

        private void AddStaticObject(GameObject obj)
        {
            this.staticObjects.Add(obj);
            this.allObjects.Add(obj);
        }

        private void AddMovingObject(MovingObject obj)
        {
            this.movingObjects.Add(obj);
            this.allObjects.Add(obj);
        }

        public virtual void AddObject(GameObject obj)
        {
            if (obj is MovingObject)
            {
                this.AddMovingObject(obj as MovingObject);
            }
            else
            {
                if (obj is Racket)
                {
                    AddRacket(obj);

                }
                else
                {
                    this.AddStaticObject(obj);
                }
            }
        }

        private void AddRacket(GameObject obj)
        {
            //03. Search for a "TODO" in the Engine class, regarding the AddRacket method. Solve the problem mentioned
            //    there. There should always be only one Racket. Note: comment in TODO not completely correct
            // TODO: we should remove the previous racket from this.allObjects
            //================================================================================================== Task 03>
            // obj is added to staticObjects AND allObjects (AddStaticObject(obj)), which means it should be removed from both
            this.allObjects.RemoveAll(x => x is Racket);
            this.staticObjects.RemoveAll(x => x is Racket);
            //================================================================================================== >Task 03

            this.playerRacket = obj as Racket;
            this.AddStaticObject(obj);
        }

        public virtual void MovePlayerRacketLeft()
        {
            // Added condition to avoid the racket going out of the "field" (left side)
            //============================================================================================= Addition>
            if (this.playerRacket.TopLeft.Col != 1)
            {
                this.playerRacket.MoveLeft();
            }
            //============================================================================================= >Addition
        }

        public virtual void MovePlayerRacketRight()
        {
            // Added condition to avoid the racket going out of the "field" (right side)
            //============================================================================================= Addition>
            if (this.playerRacket.TopLeft.Col != 33)
            {
                this.playerRacket.MoveRight();
            }
            //============================================================================================= >Addition
        }

        public virtual void Run()
        {
            while (true)
            {
                this.renderer.RenderAll();

                System.Threading.Thread.Sleep(this.ThreadSleepTime);

                this.userInterface.ProcessInput();

                this.renderer.ClearQueue();

                foreach (var obj in this.allObjects)
                {
                    obj.Update();
                    this.renderer.EnqueueForRendering(obj);
                }

                CollisionDispatcher.HandleCollisions(this.movingObjects, this.staticObjects);

                List<GameObject> producedObjects = new List<GameObject>();

                foreach (var obj in this.allObjects)
                {
                    producedObjects.AddRange(obj.ProduceObjects());
                }

                this.allObjects.RemoveAll(obj => obj.IsDestroyed);
                this.movingObjects.RemoveAll(obj => obj.IsDestroyed);
                this.staticObjects.RemoveAll(obj => obj.IsDestroyed);

                foreach (var obj in producedObjects)
                {
                    this.AddObject(obj);
                }
            }
        }
    }
}
