namespace AcademyPopcorn
{
    using System;

    class AcademyPopcornMain
    {
        // Each task description is put as comment right before its implementation.
        // Ocasionaly there are 'Additions' and 'Edits' for things that are not required by any task.
        // Also there are 'Testings' for the tasks that are reqired to be tested by their description.
        // 'xxx>' - starting section, '>xxx' - ending section
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            // I've added the following lines to adjust the size of the console so it's not unnecessarily big
            //================================================================================================= Addition>
            Console.WindowHeight = WorldRows + 2;
            Console.WindowWidth = WorldCols + 1;
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            //================================================================================================= >Addition

            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            //01. The AcademyPopcorn class contains an IndestructibleBlock class. Use it to create side and ceiling walls
            //    to the game. You can ONLY edit the AcademyPopcornMain.cs file.
            //================================================================================================== Task 01>
            for (int row = 0; row < WorldRows; row++)
            {
                IndestructibleBlock leftWallBlock = new IndestructibleBlock(new MatrixCoords(row, 0));
                engine.AddObject(leftWallBlock);

                IndestructibleBlock rightWallBlock = new IndestructibleBlock(new MatrixCoords(row, WorldCols - 1));
                engine.AddObject(rightWallBlock);
            }

            for (int col = 0; col < WorldCols; col++)
            {
                IndestructibleBlock ceilingBlock = new IndestructibleBlock(new MatrixCoords(0, col));
                engine.AddObject(ceilingBlock);
            }
            //================================================================================================== >Task 01

            for (int i = startCol; i < endCol; i++)
            {
                if (i % 3 != 1)
                {
                    Block regularBlock = new Block(new MatrixCoords(startRow, i));
                    engine.AddObject(regularBlock);
                }
                else
                {
                    // Test ExplodingBlock (TASK 10)
                    //========================================================================================= Addition>
                    ExplodingBlock explodingBlock = new ExplodingBlock(new MatrixCoords(startRow, i));
                    engine.AddObject(explodingBlock);
                    //========================================================================================= >Addition
                }
            }

            for (int i = startCol + 5; i < endCol - 5; i++)
            {
                if (i % 3 != 1)
                {
                    Block regularBlock = new Block(new MatrixCoords(startRow + 4, i));
                    engine.AddObject(regularBlock);
                }
                else
                {
                    // Test GiftBlock and Gift (TASK 11 & 12)
                    //========================================================================================= Addition>
                    GiftBlock giftBlock = new GiftBlock(new MatrixCoords(startRow + 4, i));
                    engine.AddObject(giftBlock);
                    //========================================================================================= >Addition
                }
            }

            //09. Test the UnpassableBlock and the UnstoppableBall by adding them to the engine in AcademyPopcornMain.cs file
            //================================================================================================== Task 09>
            for (int i = startCol + 10; i < endCol - 10; i++)
            {
                UnpassableBlock unpassableBlock = new UnpassableBlock(new MatrixCoords(startRow + 2, i));
                engine.AddObject(unpassableBlock);
            }
            //================================================================================================== >Task 09

            //07. Test the MeteoriteBall by replacing the normal ball in the AcademyPopcornMain.cs file.
            //================================================================================================== Task 07>
            // You just need to comment the line below \/
            Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));
            //MeteoriteBall theBall = new MeteoriteBall(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));
            //================================================================================================== Task 09>>
            //UnstoppableBall theBall = new UnstoppableBall(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));
            //========================================================================================= >>Task 09 >Task 07

            engine.AddObject(theBall);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);
            engine.AddObject(theRacket);

            // Testing TrailObject
            //=============================================================================================== Testing 05>
            //for (int i = 1; i < 10; i++)
            //{
            //    TrailObject trail = new TrailObject(new MatrixCoords(i * 2, 3 + i * 2), 10);
            //    engine.AddObject(trail);
            //}
            //=============================================================================================== >Testing 05
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            // Switched the constructor with the one where the thread sleep recives a value instead of having it hardcoded (TASK 02)
            // Also switched to ShooterEngine
            //===================================================================================================== Edit>
            ShooterEngine gameEngine = new ShooterEngine(renderer, keyboard, 150);
            //===================================================================================================== >Edit

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            keyboard.OnActionPressed += (sender, eventInfo) =>
            {
                gameEngine.ShootPlayerRacket();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
