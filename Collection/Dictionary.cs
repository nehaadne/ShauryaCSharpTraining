using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShauryaCSharpTraining
{
    //Dictionary using dublicate key
    class MyDictionary
    {
        static void Main1(string[] args)
        {
            Dictionary<Studd, string> d1 = new Dictionary<Studd, string>();
            d1.Add(new Studd(1, "neha", 90), "Shaurya");
            d1.Add(new Studd(1, "neha", 90), "Shaurya");
            foreach(KeyValuePair<Studd, string> kv in d1)
                Console.WriteLine(kv.Key+ " "+ kv.Value);
        }
    }

    class DemoDictionary
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d1 = new Dictionary<int, string>();
            d1.Add(101, "Neha");
            d1.Add(102, "Swarom");
            d1.Add(103, "Neha");
            Console.WriteLine(d1[101]);
            d1[103] = "Jivan";//replace
            d1.Remove(102);
            foreach(KeyValuePair<int, string> kv in d1)
            {
                Console.WriteLine(kv.Key+"=>"+kv.Value);
            }
            //using string key value
            Dictionary<string, string> My_dict2 =
             new Dictionary<string, string>(){
                                  {"1", "neha"},
                                  {"2", "swati"},
                                  {"3", "mansi"} };

            foreach (KeyValuePair<string, string> ele2 in My_dict2)
            {
                Console.WriteLine("{0} and {1}", ele2.Key, ele2.Value);
            }

            // Creating a dictionary
            // using Dictionary<TKey,TValue> class
            Dictionary<int, string> My_dict =
                          new Dictionary<int, string>();

            // Adding key/value pairs in the 
            // Dictionary Using Add() method
            My_dict.Add(1123, "Yog");
            My_dict.Add(1124, "Amit");
            My_dict.Add(1125, "Utkarsh");

            // Using ContainsKey() method to check
            // the specified key is present or not
            if (My_dict.ContainsKey(1122) == true)
            {
                Console.WriteLine("Key is found...!!");
            }

            else
            {
                Console.WriteLine("Key is not found...!!");
            }

            // Using ContainsValue() method to check
            // the specified value is present or not
            if (My_dict.ContainsValue("Yog") == true)
            {
                Console.WriteLine("Value is found...!!");
            }

            else
            {
                Console.WriteLine("Value is not found...!!");
            }

        }

    }
}
