using System;

namespace Student_ClassLibrary
{
    public class Student
    {

          //fields(data members)
            int StudentId;
            string StudentName;
            string Address;
            //static data member


            static string UniversityName;
            static string ApplicationVersion;
            static string ApplicationName;
            static Student()// static constructor
            {
                UniversityName = "Amity";
                ApplicationName = "SMS";
                ApplicationVersion = "v001";
            }
        public void GetDetails()
        {
            Console.Write("Enter Student ID ");
            this.StudentId = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name ");
            this.StudentName = Console.ReadLine();
            Console.Write("Enter Address ");
            this.Address = Console.ReadLine();
        }

        public static void ShowApplicationDetails()
        {
            Console.WriteLine("Application Version :{0}", ApplicationVersion);
            Console.WriteLine("Application Version :{0}", ApplicationName);

        }
        public void ShowDetails()
        {
            Console.WriteLine("Student Details: ");
            Console.WriteLine("Student Id : {0}", this.StudentId);
            Console.WriteLine("Student Name : {0}", this.StudentName);
            Console.WriteLine("Student Address : {0}", this.Address);
            Console.WriteLine("University Name :{0}", UniversityName);
        }



    }
}
