namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public class Class : ICommentable
    {
        private string uniqueTextIdentifier;
        private List<Student> Students;
        private List<Teacher> Teachers;

        public List<string> Comments { get; set; }

        public string UTI
        {
            get
            {
                return this.uniqueTextIdentifier;
            }
            set
            {
                this.uniqueTextIdentifier = value;
            }
        }

        public Class(List<Student> students, List<Teacher> teachers, string uniqueTextIdentifier)
        {
            this.Students = students;
            this.Teachers = teachers;
            this.UTI = uniqueTextIdentifier;
        }

        public Class(string uniqueTextIdentifier)
        {
            this.UTI = uniqueTextIdentifier;
            this.Students = new List<Student>();
            this.Teachers = new List<Teacher>();
        }

        public void AddStudent(Student student)
        {
            this.Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            this.Students.Remove(student);
        }

        public void ShowStudent(int ucn)
        {
            Student student = this.Students[this.Students.FindIndex(x => x.UCN == ucn)];
            Console.WriteLine(student);
        }

        public void ShowAllStudents()
        {
            foreach (Student student in this.Students)
            {
                Console.WriteLine(student);
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            this.Teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.Teachers.Remove(teacher);
        }

        public void ShowTeacher(SchoolDiscipline discipline)
        {
            Teacher teacher = this.Teachers[this.Teachers.FindIndex(x => x.Disciplines.Contains(discipline))];
            Console.WriteLine(teacher);
        }

        public void ShowAllTeachers()
        {
            foreach (Teacher teacher in this.Teachers)
            {
                Console.WriteLine(teacher);
            }
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();

            var sortedStudents = from student in this.Students
                                 orderby student.UCN
                                 select student;

            toString.AppendLine(string.Format("Class: {0}", this.UTI));
            toString.AppendLine("Students:");

            foreach (var student in sortedStudents)
            {
                toString.AppendLine(student.ToString());
            }

            toString.AppendLine("Teachers:");

            foreach (var teacher in this.Teachers)
            {
                toString.AppendLine(teacher.ToString());
            }

            return toString.ToString();
        }
    }
}