using System;

namespace LineComparision111
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line comparision caluclations");
            CaluclateLength length = new CaluclateLength();
            double length1 = length.LineLength(30.0, 20.0, 50.0, 40.0);
            double length2 = length.LineLength(40.0, 25.0, 55.0, 45.0);
            Console.WriteLine("length of line 1:" + length1 + "and length of line2" + length2);
            if (length1.CompareTo(length2)==0)
            {
                Console.WriteLine("Lines are Equal");
            }
            if (length1.CompareTo(length2) < 0)
            {
                Console.WriteLine("line1: " + length1 + "is less than line2:" + length2);
            }
            Console.ReadLine();
        }
    }
}
