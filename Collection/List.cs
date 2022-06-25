using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShauryaCSharpTraining.Collection
{
    class List

    {
        static void Main()
        {
            List<string> myList = new List<string>() {
         "neha",
         "swati",
         "amit",
         "mansi"
        };

            Console.Write("Initial list...");
            foreach (string list in myList)
            {
                Console.WriteLine(list);
            }

            Console.Write("Using Remove() method...");
            myList.Remove("swati");

            foreach (string list in myList)
            {
                Console.WriteLine(list);
            }

            Console.Write("Using RemoveAt() method...");
            myList.RemoveAt(1);

            foreach (string list in myList)
            {
                Console.WriteLine(list);
            }
        }

    }

}    


