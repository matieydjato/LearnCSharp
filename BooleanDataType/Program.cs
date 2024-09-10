using System;

namespace BooleanDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isEnabled = true;
            bool isMale = true;
            isMale = false;
            Console.WriteLine("isEnabled " + isEnabled); // True
            Console.WriteLine("isMale " + isMale); // False
        }
    }
}
