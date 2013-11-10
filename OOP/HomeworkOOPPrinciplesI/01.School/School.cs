namespace School
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Class> Classes { get; set; }

        public School(string name)
        {
            this.Name = name;
            this.Classes = new List<Class>();
        }

        public School(string name, List<Class> classes)
            : this(name)
        {
            this.Classes = classes;
        }
    }
}