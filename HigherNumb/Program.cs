using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherNumb
{
    class Program
    {
        static void Main(string[] args)
        {   
            //---- Με List------//
            List<int> numbers = new List<int> { 10, 5, 32, 9, -1, 68, 250, 2 };

            int highestNumb = numbers.Max();

            Console.WriteLine("The highest number is {0}", highestNumb);

            //----------Με Array---------------//

            int[] n = new int[] { 10, 5, 32, 9, -1, 68, 250, 2 };
            Console.WriteLine(MaxValue(n));   

        }
        public static int MaxValue(int[] n)
        {
            int Max = int.MaxValue;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] > Max)
                {
                    Max = n[i];
                }
            }
            return Max;
        }
    }
}
