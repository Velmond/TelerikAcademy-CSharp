//-----------------------------------------------------------------------
// <copyright file="SimpleMathExam.cs" company="TelerikAcademy">
//     Copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace ExceptionsHomework
{
    using System;

    public class SimpleMathExam : Exam
    {
        private int problemsSolved;

        public SimpleMathExam(int problemsSolved)
        {
            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved
        {
            get
            {
                return this.problemsSolved;
            }

            private set
            {
                if (value < 0 || value > 2)
                {
                    throw new ArgumentOutOfRangeException("The number of problems solved cannot be less than 0 or more than 10.");
                }

                this.problemsSolved = value;
            }
        }

        public override ExamResult Check()
        {
            if (this.ProblemsSolved == 2)
            {
                return new ExamResult(6, 2, 6, "Average result: nothing done.");
            }
            else if (this.ProblemsSolved == 1)
            {
                return new ExamResult(4, 2, 6, "Average result: nothing done.");
            }
            else
            {
                //// this.ProblemsSolved == 0
                return new ExamResult(2, 2, 6, "Bad result: nothing done.");
            }
        }
    }
}
