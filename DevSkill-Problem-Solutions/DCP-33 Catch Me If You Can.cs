using System;

public class Test
{
	public static void Main()

        {
            int t;

            t = int.Parse(Console.ReadLine());

            for (int p = 1; p <= t; p++)
            {
                var line = Console.ReadLine();
                var arr = line.Split(' ');
                var a = int.Parse(arr[0]);
                var b = int.Parse(arr[1]);
                var c = int.Parse(arr[2]);
                var d = int.Parse(arr[3]);

                int e = a * d;
                int f = (b * d) + c;

                if (f < e || (c == 0 && d > 0))
                {
                    Console.WriteLine("Case " + p + ": Abir will be arrested");
                }
                else
                {
                    Console.WriteLine("Case " + p + ": Abir will survive");
                }
                Console.ReadLine();
            }
}