using System;

public class Test
{
	public static void Main()
        {
            int t;

            t = int.Parse(Console.ReadLine());

            for (int i = 1; i <= t; i++)
            {
            	long n;
                n = long.Parse(Console.ReadLine());

                n *= 3;
                Console.Write("Case #{0}: ", i);

                if (n % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2}", n, n - 1, n - 2);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", n - 2, n - 1, n);
                }

            }
            Console.ReadLine();
        }
}