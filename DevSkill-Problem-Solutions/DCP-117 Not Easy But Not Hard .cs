using System;

public class Test
{
	public static void Main()
        {
            int t;

            t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                long n;
                n = long.Parse(Console.ReadLine());

                Console.WriteLine("{0}", (n * (n + 1)) / 2);

            }
            Console.ReadLine();
        }
}