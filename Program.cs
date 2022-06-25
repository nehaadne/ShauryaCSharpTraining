using System;
//class A
//{
//    public static void Main()
//    {
//        try
//        {
//            Console.WriteLine("Enter number");
//            int n = int.Parse(Console.ReadLine());
//            Console.WriteLine("try ends");
//        }
//        catch(FormatException e)
//        {
//            Console.WriteLine(e.Message);
//            Console.WriteLine("wrong input");
//        }
//        for(int i=2;i<=20;i=i+2)
//            Console.WriteLine(i);
//    }
//}

class InvalidPasswordException : Exception
{
    public InvalidPasswordException(string msg) : base(msg)
    {

    }
    public InvalidPasswordException()
    {

    }
    class Demo
    {
        string pass;

        public string Password
        {
            set
            {
                if (value.Length < 5)
                    throw new InvalidPasswordException();
                pass = value;
            }
        }
        class Empp
        {
            static void Main1(string[] args)
            {
                Empp e1 = new Empp();
                Demo ob = new Demo();
                try
                {
                    ob.Password = "neha";
                }
                catch (InvalidPasswordException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine();
            }
        }
    }
}

