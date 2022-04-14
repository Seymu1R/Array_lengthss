using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            string[] arr = { "Seymur", "Elşən", "Fəxri", "Cavid", "Sabina", "Lamiya", "Ali" };
            while (true)
            {
                if (arr[i].Length > 5)
                {
                    Console.WriteLine(arr[i]);
                }
                i++;
            }

            
        }
    }
}
