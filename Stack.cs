using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
   public class Stack
    {
        public void stackDisplay()
        {
            Stack<int> stack  = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);
            stack.Push(60);

            foreach(int ele in stack)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine("Peek"+stack.Peek());
            Console.WriteLine("-------------------");

            stack.Pop();
            Console.WriteLine("Peek" + stack.Peek());

            foreach(int ele in stack)
            { 
                Console.WriteLine(ele);
            }
       }
    }
}
