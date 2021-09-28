using Sport_ClassLibrary;
using System;

namespace Result_ClassLibrary
{
    public class Result : Sport
    {
        protected float TotalMarks, AverageMarks;
        public void Calculate()
        {
            this.TotalMarks = this.ObjectiveMarks + this.SubjectiveMarks + this.score;
            this.AverageMarks = this.TotalMarks / 3;
            Console.WriteLine("Total Marks:" + this.TotalMarks);
            Console.WriteLine(" Average:" + this.AverageMarks);

        }

    }
}
