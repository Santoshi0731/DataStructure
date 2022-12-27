using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Queue
    {
        public void DisplayQueue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);

            foreach (int ele in queue)
            { 
                Console.WriteLine(ele);
            }
            Console.WriteLine("Peek" + queue.Peek());
            Console.WriteLine("---------------------");

            queue.Dequeue();
            Console.WriteLine("Peek" + queue.Peek());
            foreach(int ele in queue)
            {
                    Console.WriteLine(ele);
            }
        }   
    }
}
