namespace AnimalHierarchy
{
    using System;

    class Frog : Animal
    {
        public Frog(string name, int age, Sex sex)
            : base(name, age, sex)
        { }


        public override string MakeSound()
        {
            return "Ribbit ribbit!";
        }
    }
}
