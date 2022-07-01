using System;
using System.Collections;


namespace ShauryaCSharpTraining
{
    class aList
    {
        public static void Main1(string[]args)
        {
            ArrayList al = new ArrayList(100);
            al.Add(90);
            al.Add(95);
            al.Add("neha");
            al[0] = 1200; //replace
            al.Add(789);
            for(int i=0; i<al.Count;i++)
            {
                Console.WriteLine(al[i]);
            }
            foreach(object ob in al)
            {
                Console.WriteLine(ob);
            }
            
        }
    }
}
