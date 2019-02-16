using System;

public class Test
{
	public static void Main()
        {
            int t, c = 0, sum, m = Int32.MinValue;

            t = int.Parse(Console.ReadLine());

            for (int i = 1; i <= t; i++)
            {
                c++;
                sum = 0;

                var line = Console.ReadLine();
                var n = line.Split(' ');

                var b = Convert.ToInt32(n[0]);
                var s = Convert.ToInt32(n[1]);
                var g = Convert.ToInt32(n[2]);
                var r = Convert.ToInt32(n[3]);

                sum = b + (s * 3) + (g * 10) - (r * 5);
                m = Math.Max(m, sum);

                if(sum<0)
                {
                    sum = 0;
                }
                Console.WriteLine("Player {0}: {1}", c, sum);
            }
            Console.WriteLine("High Score = {0}", m);

            Console.ReadLine();
        }
}