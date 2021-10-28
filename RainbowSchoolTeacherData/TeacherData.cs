using System;
using System.IO;
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
                
                Teacher teacherdetails = new Teacher()
                {
                   
                    ID = 123,
                    Name = "Priya",
                    ClassandSection = "6A",


                };

             
                Stream stream = new FileStream("C:\\data\\TeacherDetails.txt", FileMode.Create, FileAccess.Write);
                IFormatter formatter = new BinaryFormatter();

                formatter.Serialize(stream,teacherdetails);
                Console.WriteLine("Content success");
                stream.Close();
                Console.ReadKey();
             
            
            }



            public void RetrieveData()
            {
                throw new NotImplementedException();
            }

           
            public void UpdateData()
            {
                throw new NotImplementedException();
            }


        }

        public void Deserialize()

        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("C:\\data\\TeacherDetails.txt", FileMode.Open, FileAccess.Read);

            Teacher teachObj = (Teacher)formatter.Deserialize(stream);
            Console.WriteLine("{0},{1},{2}", teachObj.Name, teachObj.ID, teachObj.ClassandSection);

            stream.Close();
            Console.ReadKey();
        }



        public static void Main(string[] args)
        {
            ITeacher teacher_details = new TeacherDetails();
            teacher_details.StoreData();
            TeacherData data = new TeacherData();
            data.Deserialize();
            Console.ReadKey();


        }
    }
}
