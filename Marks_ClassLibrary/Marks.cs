using Student_ClassLibrary;
using System;

namespace Marks_ClassLibrary
{
    public class Marks : Student
    {
        protected float ObjectiveMarks, SubjectiveMarks;


        protected new void GetDetails()
        {
            base.GetDetails();
            Console.Write("Enter Objective Marks");

            this.ObjectiveMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter Student Name ");
            this.SubjectiveMarks = float.Parse(Console.ReadLine());

        }

        protected new void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("ObjectiveMarks: {0}", ObjectiveMarks);
            Console.WriteLine("SubjectiveMarks : {0}", SubjectiveMarks);

        }

    }
}
