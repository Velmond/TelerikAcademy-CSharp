namespace AnimalHierarchy
{
    using System;

    class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, Sex.f)
        { }

        public override string MakeSound()
        {
            return "Meooooooow";
        }
    }
}
