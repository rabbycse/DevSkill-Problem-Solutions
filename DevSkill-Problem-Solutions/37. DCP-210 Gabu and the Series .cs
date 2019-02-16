using System;

public class Test
{
       static long[]  ar = new long[1000001] ;
       public static void series()
        {
            ar[1] = 0;
            ar[2] = 2;
            int i = 3;
            long p = 6;
            while (i < 1000001)
            {
                ar[i] = ar[i - 1] + p;
                p += 4;
                i++;
            }
        }

        public static void Main()
        {
            series();
            int t;
            long n;
            t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                n = int.Parse(Console.ReadLine());
           
                Console.WriteLine(ar[n]);
            }

            Console.ReadLine();
        }
}