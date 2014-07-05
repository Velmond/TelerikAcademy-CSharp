//-----------------------------------------------------------------------
// <copyright file="Student.cs" company="TelerikAcademy">
//     Copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace ExceptionsHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        private string firstName;
        private string lastName;
        private IList<Exam> exams;

        public Student(string firstName, string lastName, IList<Exam> exams)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Exams = exams;
        }

        public Student(string firstName, string lastName)
            : this(firstName, lastName, new List<Exam>())
        {
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("name", "Name cannot be null.");
                }

                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("name", "Name can't be less than 2 characters long.");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("name", "Name cannot be null.");
                }

                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("name", "Name can't be less than 2 characters long.");
                }

                this.lastName = value;
            }
        }

        public IList<Exam> Exams
        {
            get
            {
                return this.exams;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("name", "Name cannot be null.");
                }

                this.exams = new List<Exam>();
                foreach (var exam in value)
                {
                    this.exams.Add(exam);
                }
            }
        }

        public double CalcAverageExamResultInPercents()
        {
            if (this.Exams.Count == 0)
            {
                throw new ArgumentException("Student has not had any exams.");
            }

            double[] examScore = new double[this.Exams.Count];
            IList<ExamResult> examResults = this.CheckExams();
            for (int i = 0; i < examResults.Count; i++)
            {
                examScore[i] =
                    ((double)examResults[i].Grade - examResults[i].MinGrade) /
                    (examResults[i].MaxGrade - examResults[i].MinGrade);
            }

            return examScore.Average();
        }

        private IList<ExamResult> CheckExams()
        {
            if (this.Exams.Count == 0)
            {
                throw new ArgumentException("Student has not had any exams.");
            }

            IList<ExamResult> results = new List<ExamResult>();
            for (int i = 0; i < this.Exams.Count; i++)
            {
                results.Add(this.Exams[i].Check());
            }

            return results;
        }
    }
}
