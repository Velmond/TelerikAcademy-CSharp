namespace AnimalHierarchy
{
    using System;

    class Dog : Animal
    {
        public Dog(string name, int age, Sex sex)
            : base(name, age, sex)
        { }

        public override string MakeSound()
        {
            return "Woof woof!";
        }
    }
}