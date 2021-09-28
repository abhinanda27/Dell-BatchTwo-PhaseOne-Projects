using Result_ClassLibrary;
using System;

namespace CSharp_DayTwo_Projects
{

    //class Student
    //{
    //    //fields(data members)
    //    int StudentId;
    //    string StudentName;
    //    string Address;
    //    //static data member


    //    static string UniversityName;
    //    static string ApplicationVersion;
    //    static string ApplicationName;
    //    static Student()// static constructor
    //    {
    //        UniversityName = "Amity";
    //        ApplicationName = "SMS";
    //        ApplicationVersion = "v001";
    //    }


    //    public class Marks : Student
    //    {

    //        public float ObjectiveMarks, SubjectiveMarks;

          
    //        public new void GetDetails()
    //        {
    //            base.GetDetails();
    //            Console.Write("Enter Objective Marks");
                
    //            this.ObjectiveMarks = float.Parse(Console.ReadLine());
    //            Console.Write("Enter Student Name ");
    //            this.SubjectiveMarks = float.Parse(Console.ReadLine());

    //        }

    //        public new void ShowDetails()
    //        {
    //            base.ShowDetails();
    //            Console.WriteLine("ObjectiveMarks: {0}",ObjectiveMarks);
    //            Console.WriteLine("SubjectiveMarks : {0}", SubjectiveMarks);
                
    //        }


    //        public void DisplayDetails()
    //        {
    //            Console.WriteLine("Objective Marks :{0}", this.ObjectiveMarks);
    //            Console.WriteLine("Subjective Marks :{0}", this.SubjectiveMarks);
    //        }
    //    }

    //    class Sport : Marks
    //    {
    //       public float score;
    //        protected new void GetDetails()
    //        {
    //            base.GetDetails();
    //            Console.Write("Enter Score");
    //            this.score = float.Parse(Console.ReadLine());
               

    //        }

    //        public new void ShowDetails()
    //        {
    //            base.ShowDetails();
    //            Console.WriteLine("score: {0}", this.score);
               
    //        }
    //    }


    //    class Result : Sport
    //    {
    //        protected float TotalMarks, AverageMarks;
    //        public void Calculate()
    //        {
    //            this.TotalMarks = this.ObjectiveMarks + this.SubjectiveMarks + this.score;
    //            this.AverageMarks = this.TotalMarks / 3;
    //            Console.WriteLine("Total Marks:" + this.TotalMarks);
    //            Console.WriteLine(" Average:" + this.AverageMarks);

    //        }

    //        public new void ShowDetails()
    //        {
    //            base.ShowDetails();
    //            Console.WriteLine("score: {0}", this.score);

    //        }
    //    }
    //    //Constructors

    //    public Student()//Default Contructor
    //    {
    //        this.StudentId = 1000;
    //        this.StudentName = " Shiv Prasad";
    //        this.Address = "Chennai";
    //    }

    //    //Parameterized Constructor
    //    public Student(int StudentId, string StudentName, string StudentAddress)
    //    {
    //        this.StudentId = StudentId;
    //        this.StudentName = StudentName;
    //        this.Address = StudentAddress;
    //    }

    //    //Copy Constructor
    //    public Student(Student student)
    //    {
    //        this.StudentId = student.StudentId;
    //        this.StudentName = student.StudentName;
    //        this.Address = student.Address;

    //    }

    //    //method(member functions)
    //    public void GetDetails()
    //    {
    //        Console.Write("Enter Student ID ");
    //        this.StudentId = int.Parse(Console.ReadLine());
    //        Console.Write("Enter Student Name ");
    //        this.StudentName = Console.ReadLine();
    //        Console.Write("Enter Address ");
    //        this.Address = Console.ReadLine();
    //    }

    //    public static void ShowApplicationDetails()
    //    {
    //        Console.WriteLine("Application Version :{0}", ApplicationVersion);
    //        Console.WriteLine("Application Version :{0}", ApplicationName);

    //    }
    //    public void ShowDetails()
    //    {
    //        Console.WriteLine("Student Details: ");
    //        Console.WriteLine("Student Id : {0}", this.StudentId);
    //        Console.WriteLine("Student Name : {0}", this.StudentName);
    //        Console.WriteLine("Student Address : {0}", this.Address);
    //        Console.WriteLine("University Name :{0}", UniversityName);
    //    }


        class MainEntry
        {
            static void Main(string[] args)
            {

                Result marks = new Result();
                marks.GetDetails();
                marks.ShowDetails();
                marks.Calculate();
                
            }

        }

    
}
