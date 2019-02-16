using System;

public class Test
{
	 public static void Main()
        {
           
            int t;

            t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                long n, r, r1;
                n = long.Parse(Console.ReadLine());

                r = (n * (n + 1)) / 2;
                r *= r;
                r1 = (n * (n + 1) * (2 * n + 1)) / 6;

                Console.WriteLine("{0}", r - r1);

            }
            Console.ReadLine();
        }
}