using System;

namespace HelloMethods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string message = Message.GetMessage("tr");
            
            double[] someInts = new double[1];
            someInts[0] = 25.5;
            string[] someWords = new string[5];
            someWords[0] = "The first word of the array";
            int[] someOtherInts = {0, 1, 2};
            int anInt = someOtherInts[2];
            Console.WriteLine(someWords[0]);
            Console.WriteLine(someOtherInts[2]);
            Console.WriteLine(anInt);

            Program test = new Program();
            test.Print();

            Console.WriteLine(message.ToLower());
            Console.WriteLine("Name: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hey {userName}!");

        }
        void Print()
        {
            Console.WriteLine("Hello there you all");
        }
    }
}
