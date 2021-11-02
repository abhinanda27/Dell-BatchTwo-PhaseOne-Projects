using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace RainbowSchoolTeacherData
{
    public class TeacherData
    {
        [Serializable]
        public class Teacher
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string ClassandSection { get; set; }
        }
        interface ITeacher
        {
            void StoreData();
            void RetrieveData();
            void UpdateData();
        }

        
        class TeacherDetails : ITeacher
        {

            public void StoreData()
            {
                try
                {
                    Teacher teacherdetails = new Teacher();

                    do
                    {
                        Console.WriteLine("Enter Teacher ID :");
                        teacherdetails.ID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Teacher Name :");
                        teacherdetails.Name = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter Teacher Class And Section :");
                        teacherdetails.ClassandSection = Convert.ToString(Console.ReadLine());

                        Stream stream = new FileStream("C:\\data\\TeacherDetails.txt", FileMode.Append, FileAccess.Write);
                        
                        
                        IFormatter formatter = new BinaryFormatter();

                        formatter.Serialize(stream, teacherdetails);
                        Console.WriteLine("Content success");
                        stream.Close();
                    }

                    while (teacherdetails.ID!=100);

                    if(teacherdetails.ID == 0 || teacherdetails.ID ==-1)
                    {
                        Console.WriteLine("Wrong Input");
                        
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }



            public void RetrieveData()

            {

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("C:\\data\\TeacherDetails.txt", FileMode.OpenOrCreate, FileAccess.Read);
                try
                {
                    foreach (var obj in stream.ToString())
                    {
                        if (stream.Length != 0)
                        {

                            Teacher teachObj = (Teacher)formatter.Deserialize(stream);
                            Console.WriteLine("Name :{0}, ID :{1},ClassandSection :{2}", teachObj.Name, teachObj.ID, teachObj.ClassandSection);
                        }
                    }
                   
                    stream.Close();
                    Console.ReadKey();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
               

            }

           
            public void UpdateData()
            {
                
            }


        }

      



        public static void Main(string[] args)
        {
            ITeacher teacher_details = new TeacherDetails();
            teacher_details.StoreData();
            teacher_details.RetrieveData();
            Console.ReadKey();


        }
    }
}
