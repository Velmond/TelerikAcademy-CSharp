//03. Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.
//    Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface).
//    Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only
//    female and tomcats can be only male. Each animal produces a specific sound. Create arrays of different
//    kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).

namespace AnimalHierarchy
{
    using System;
    using System.Collections;

    class TestApplication
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.White;

            TestFrog();
            TestDog();
            TestCat();
        }

        private static void TestFrog()
        {
            Frog[] frogs = {
                               new Frog("Oscar", 1, Sex.m),
                               new Frog("Abbie", 2, Sex.f),
                               new Frog("Acro", 5, Sex.m),
                               new Frog("Baloo", 2, Sex.m),
                               new Frog("Bernard", 3, Sex.m),
                               new Frog("Chubbie", 4, Sex.f),
                               new Frog("Flubber", 1, Sex.m),
                               new Frog("Echo", 5, Sex.m),
                           };

            Console.WriteLine("Frog goes: " + frogs[0].MakeSound());

            Console.Write("Avarage frog age: ");
            DisplayAvarageAge(frogs);
        }

        private static void TestDog()
        {
            Dog[] dogs = {
                               new Dog("Sharoh", 5, Sex.m),
                               new Dog("Donna", 6, Sex.f),
                               new Dog("Dino", 7, Sex.m),
                               new Dog("Rex", 9, Sex.m),
                               new Dog("Perry", 11, Sex.m),
                               new Dog("Duchess", 10, Sex.f),
                               new Dog("Sarah", 7, Sex.f),
                               new Dog("Max", 3, Sex.m),
                           };

            Console.WriteLine("Dog goes: " + dogs[0].MakeSound());

            Console.Write("Avarage dog age: ");
            DisplayAvarageAge(dogs);
        }

        private static void TestCat()
        {
            Cat[] cats = {
                               new Cat("Princess", 7, Sex.f),
                               new Tomcat("Tom", 4),
                               new Kitten("Pisána", 3),
                               new Cat("Jerry", 8, Sex.m),
                               new Tomcat("Matty", 10),
                               new Kitten("Kitty", 9),
                               new Kitten("Jeannie", 7),
                               new Tomcat("Johnny", 6),
                           };

            Console.WriteLine("Cat goes: " + cats[0].MakeSound());
            Console.WriteLine("Tomcat goes: " + cats[1].MakeSound());
            Console.WriteLine("Kitten goes: " + cats[2].MakeSound());

            Console.Write("Avarage cat age: ");
            DisplayAvarageAge(cats);
        }

        private static void DisplayAvarageAge(Animal[] animals)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0:f2}", Animal.AvarageAge(animals));
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}