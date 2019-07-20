using System;

public class Test
{
	 public static void Main()
        {

            int t;
            double r;

            t = int.Parse(Console.ReadLine());

            for (int i = 1; i <= t; i++)
            {
                int n;
                n = int.Parse(Console.ReadLine());

                r = Math.Ceiling(((Math.Sqrt(1.0 + (8 * n))) - 1.0) / 2.0);

                Console.WriteLine("{0}", r);

            }
            Console.ReadLine();
        }
}