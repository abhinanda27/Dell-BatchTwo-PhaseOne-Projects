using Marks_ClassLibrary;
using System;

namespace Sport_ClassLibrary
{
    public class Sport : Marks
    {
        public float score;
        protected new void GetDetails()
        {
            base.GetDetails();
            Console.Write("Enter Score");
            this.score = float.Parse(Console.ReadLine());


        }

        public new void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("score: {0}", this.score);

        }
    }


}
