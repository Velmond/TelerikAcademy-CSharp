// Task 02. Refactor the following examples to produce code with well-named identifiers in C#:

namespace PersonInitializer
{
    using System;
    using System.Linq;

    public class PersonInitializer
    {
        public enum Gender
        {
            Male,
            Female
        }

        public void InitializePerson(int age)
        {
            Person newPerson = new Person();
            newPerson.Age = age;

            if (age % 2 == 0)
            {
                newPerson.Name = "Батката";
                newPerson.Gender = Gender.Male;
            }
            else
            {
                newPerson.Name = "Мацето";
                newPerson.Gender = Gender.Female;
            }
        }

        public class Person
        {
            public Gender Gender { get; set; }

            public string Name { get; set; }
            
            public int Age { get; set; }
        }
    }
}
