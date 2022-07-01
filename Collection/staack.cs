using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShauryaCSharpTraining
{
    class staack
    {
        static void Main1(string[] args)
        {
            Stack<string> st = new Stack<string>();
            st.Push("neha");
            foreach (string sd in st)
                Console.WriteLine(sd);
            String data = st.Pop();
            Console.WriteLine("Data Removed " + data);
            Console.WriteLine("..............");
            foreach (string sd in st)
                Console.WriteLine(sd);

        }
    }


    class DemoList
    {
        static void Main2(string[] args)
        {
            List<int> st = new List<int>();
            st.Add(90);
            st.Add(80);
            st.Add(60);
            st.Insert(0, 1);
            st[2] = 11111;
            Console.WriteLine(st.Contains(900));
            foreach (int sd in st)
                Console.WriteLine(sd);

        }
    }
    class DemoQueue
    {
        public static void Main3(string[] args)
        {
            Queue<String> q = new Queue<string>();
            q.Enqueue("A");
            q.Enqueue("B");
            q.Enqueue("C");

            foreach(string d in q)
                Console.WriteLine(d);
            String data = q.Dequeue();
            Console.WriteLine("Removed "+ data);
            Console.WriteLine("*************");

        }
    }

    class Demo8
    {

        static void Main4(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("pune");
            al.Add("Mumbai");
            al.Add("pune");
            al.Add("Mumbai");
            al.Add("Nasik");
            al.Add("pune");

            Hashtable ht = new Hashtable();

            Console.WriteLine("Elements of ArrayList : ");
            foreach (dynamic obj in al)
            {
                Console.WriteLine(obj);
            }


            foreach (dynamic data in al)
            {
                if (ht.ContainsKey(data))
                {
                    int value = (int)ht[data];
                    ht[data] = value + 1;
                }
                else
                {
                    ht.Add(data, 1);
                }
            }


            Console.WriteLine("Elements of hashtable : ");
            foreach (DictionaryEntry obj in ht)
            {
                Console.WriteLine(obj.Key + "==>" + obj.Value);
            }
        }
    }
    class Demo1
    {
        static void Main5(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");
            Console.WriteLine("ArrayList before remving duplicates : ");
            foreach (var item in al)
                Console.WriteLine(item);


            Console.WriteLine("ArrayList after removing duplicates : ");
            for (int i = 0; i < al.Count; i++)
            {
                for (int j = i + 1; j < al.Count; j++)
                {
                    if (al[i].Equals(al[j]))
                    {
                        al.Remove(al[i]);
                    }
                }
            }
            foreach (var obj in al)
                Console.WriteLine(obj);
        }
    }

    class Demo2
    {
        static void Main6(string[] args)
        {
            ArrayList al = new ArrayList();

            int nav = 0;
            while (true)
            {
                Console.WriteLine("Enter your favourite color : ");
                string name = Console.ReadLine();
                al.Add(name);
                nav++;
                if (nav == 4)
                {
                    Console.WriteLine("Do you want to add more : (yes/no) ");
                    string str = Console.ReadLine();
                    if (str.Length == 2)
                        break;
                    nav = 0;
                }

            }
            Console.WriteLine("ArrayList before sorting : ");
            foreach (string str1 in al)
                Console.WriteLine(str1);

            //al.Sort();
            Console.WriteLine("ArrayList after sorting : ");
            //foreach(string str2 in al)
            //Console.WriteLine(str2);
            for (var i = al.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(al[i]);
            }

        }
    }
    class Player
    {
        int playerid;
        string name;
        string country;
        string team;

        public Player(int playerid, string name, string country, string team)
        {
            this.Playerid = playerid;
            this.Name = name;
            this.Country = country;
            this.Team = team;
        }

        public int Playerid { get => playerid; set => playerid = value; }
        public string Name { get => name; set => name = value; }
        public string Country { get => country; set => country = value; }
        public string Team { get => team; set => team = value; }

        public override string ToString()
        {
            return "Player id : " + playerid + " Player Name : " + name + " Player Country : " + country + " Player team : " + team;
        }
    }

    class Demo4
    {
        /* 4.	Create ArrayList of T20 Players.
                 Create a class Player (playerid, Name, Country, team)
                 e.g.(1,”MSDhoni”,”India”,”Chennai Super Kings”)
                 Then find out which team has maximum Australian players.    */

        static void Main7(string[] args)
        {
            ArrayList al = new ArrayList();

            int tag = 0, counter = 0;
            while (true)
            {
                Console.WriteLine("How many player details you want to add : ");
                int add = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter player id : ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter player name : ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter player country : ");
                string country = Console.ReadLine().ToUpper();
                /*if(country == "AUS")
                {
                    counter++;
                }*/

                Console.WriteLine("Enter player ipl team : ");
                string team = Console.ReadLine();

                al.Add(new Player(id, name, country, team));
                tag++;

                if (tag == add)
                {
                    Console.WriteLine("Do you want to add more (yes/no):");
                    string str = Console.ReadLine();

                    if (str.Length == 2)
                        break;
                    tag = 0;
                }

            }
            Console.WriteLine("Player details are as follows : ");
            foreach (Player obj in al)
            {
                Console.WriteLine(obj);
            }

        }

    }
}





