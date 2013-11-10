namespace School
{
    using System;
    using System.Collections.Generic;

    public class Teacher : Person, ICommentable
    {
        public List<SchoolDiscipline> Disciplines { get; set; }

        public Teacher(string firstName, string lastName)
            : base(firstName, lastName)
        {
            this.Disciplines = new List<SchoolDiscipline>();
        }

        public Teacher(string firstName, string lastName, List<SchoolDiscipline> disciplines)
            : this(firstName, lastName)
        {
            this.Disciplines = disciplines;
        }

        public Teacher(string firstName, string lastName, SchoolDiscipline schoolDiscipline)
            : this(firstName, lastName)
        {
            this.Disciplines.Add(schoolDiscipline);
        }

        public Teacher(string firstName, string lastName, Subject discipline)
            : this(firstName, lastName)
        {
            this.Disciplines.Add(new SchoolDiscipline(discipline));
        }
    }
}