using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class ListDemo
    {
        public void ListDisplay()
        {
            List<string> list = new List<string>();
            list.Add("Ramesh");
            list.Add("Suresh");
            list.Add("Rita"); 
            list.Add("Avinash");

            foreach(string ele in list )
            {
                Console.WriteLine(ele);
            }

        }

    }
}
