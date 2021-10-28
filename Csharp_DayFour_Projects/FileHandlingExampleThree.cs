using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_DayFour_Projects
{
    //class Employee
    //{
    //    public string Name { get; set; }
    //    public float Salary { get; set; }
    //    public int Age { get; set; }
    //}
    //class FileHandlingExampleThree
    //{
    //    static void Main(string[] args)
    //    {
    //        Employee employee = new Employee()
    //        {
    //            Name = "King",
    //            Salary = 12000,
    //            Age = 23
    //        };

    //        IFormatter formatter = new BinaryFormatter();
    //        Stream stream = new FileStream("C:\\data\\data.txt", FileMode.Create, FileAccess
    //            .Write);
    //        formatter.Serialize(stream, employee);

    //        Console.WriteLine("Content success");
    //        stream.Close();
    //        Console.ReadKey();

    //    //Deserialization:

    //    //    IFormatter formatter = new BinaryFormatter();
    //    //    Stream stream = new FileStream("C\\data\\data.txt", FileMode.Create, FileAccess
    //    //        .Write);
    //    //    formatter.Serialize(stream, employee);
    //    //    Employee empObj = (Employee)formatter.Deserialize(stream);
    //    //    Console.WriteLine("{0},{1},{2}", empObj.Name, empObj.Salary, empObj.Age);

    //    //    stream.Close();
    //    //    Console.ReadKey();

    //    }
    //}
}
