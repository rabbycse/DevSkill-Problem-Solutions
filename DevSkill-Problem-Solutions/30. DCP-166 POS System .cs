using System;

public class Test
{
	 public static void Main()
        {
            int t;

            t = int.Parse(Console.ReadLine());

            for (int i = 1; i <= t; i++)
            {
                int n;
                n = int.Parse(Console.ReadLine());

                double total = 0.0;

                for(int j=0; j<n; j++)
                {
                    var line = Console.ReadLine();
                    var arr = line.Split(' ');

                    var p = Convert.ToDouble(arr[0]);
                    var q = Convert.ToInt32(arr[1]);

                    total += (p * q);
                }
                long g;
                g = long.Parse(Console.ReadLine());

                Console.WriteLine("Case {0}: {1}", i, Math.Floor(g - total));

            }
            Console.ReadLine();
        }
}