using System;

public class Test
{
	public static void Main()
        {

            int t;

            t = int.Parse(Console.ReadLine());

            for (int i = 1; i <= t; i++)
            {
                int k, n, sum = 0;
                n = int.Parse(Console.ReadLine());
                for (k = 1; k <= n; k++)
                {
                    sum += k * k * k;
                }
                Console.WriteLine("Case {0}: {1}", i, sum);

            }
            Console.ReadLine();
        }
}