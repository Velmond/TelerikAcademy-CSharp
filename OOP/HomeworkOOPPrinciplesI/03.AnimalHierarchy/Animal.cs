namespace AnimalHierarchy
{
    using System;

    abstract class Animal : ISound
    {
        public abstract string MakeSound();

        private int age;
        private string name;
        private Sex sex;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Sex Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public Animal(string name, int age, Sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public static double AvarageAge(Animal[] animals)
        {
            double totalAge = 0;

            foreach (Animal animal in animals)
            {
                totalAge += animal.Age;
            }

            return (totalAge / animals.Length);
        }
    }
}