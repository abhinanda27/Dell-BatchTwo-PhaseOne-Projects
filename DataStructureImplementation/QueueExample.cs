using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureImplementation
{
    class QueueExample
    {

        static void Main(string[] args)
        {

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("King");
            queue.Enqueue("Kochar");
            queue.Enqueue("Sarah");
            queue.Enqueue("Smith");

            foreach(var item in queue)
            Console.WriteLine(item);
            Console.ReadKey();

            Console.WriteLine("Elememt to dequeue" + queue.Peek());
            Console.WriteLine("Element dequeued"+ queue.Dequeue());

            foreach(var item in queue)
                Console.WriteLine(item);

            if(queue.Count!=0)
                Console.WriteLine("Queue is not empty");
            else
                Console.WriteLine("Queue is empty");
            Console.ReadKey();
        }
    }
    
}
