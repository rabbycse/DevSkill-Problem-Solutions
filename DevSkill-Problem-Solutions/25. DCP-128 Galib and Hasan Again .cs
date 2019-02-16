using System;

public class Test
{
	public static void Main()
        {
            int t;

            t = int.Parse(Console.ReadLine());

            for (int i = 1; i <= t; i++)
            {
                var line = Console.ReadLine();
                var n = line.Split(' ');

                var a = long.Parse(n[0]);
                var b = long.Parse(n[1]);

                a *= 2;

                Console.WriteLine("Case {0}: {1}",i, (a * a) - (b * b));

            }
            Console.ReadLine();
        }
}