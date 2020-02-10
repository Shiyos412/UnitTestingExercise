using System;

namespace UnitTestingExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            int m = 2;
            int n = 1;
            while (m >= n)
            {
                if ((m & (m - 1)) < n)
                {
                    Console.WriteLine(m);
                }
                m &= m - 1;
            }
                
            
        }
    }
}
