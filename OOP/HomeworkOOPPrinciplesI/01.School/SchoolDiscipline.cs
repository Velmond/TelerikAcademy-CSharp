namespace School
{
    using System;
    using System.Collections.Generic;

    public class SchoolDiscipline : ICommentable
    {
        private Subject name;
        private int? numOfLectures;
        private int? numOfExercises;

        public List<string> Comments { get; set; }

        public Subject Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int? NumOfLectures
        {
            get { return this.numOfLectures; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The number of lectures can't be less than 0.");
                }

                this.numOfLectures = value;
            }
        }

        public int? NumOfExercises
        {
            get { return this.numOfExercises; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The number of exercises can't be less than 0.");
                }

                this.numOfExercises = value;
            }
        }

        public SchoolDiscipline(Subject name, int? numOfLectures, int? numOfExercises)
        {
            this.Name = name;
            this.NumOfLectures = numOfLectures;
            this.NumOfExercises = numOfExercises;
        }

        public SchoolDiscipline(Subject name)
            : this(name, null, null)
        { }

        public override string ToString()
        {
            return string.Concat(this.Name + " (" + this.NumOfLectures + "/" + this.NumOfExercises + ")");
        }
    }
}