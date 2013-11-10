namespace AnimalHierarchy
{
    using System;

    class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, Sex.m)
        { }

        public override string MakeSound()
        {
            return "Meow";
        }
    }
}
