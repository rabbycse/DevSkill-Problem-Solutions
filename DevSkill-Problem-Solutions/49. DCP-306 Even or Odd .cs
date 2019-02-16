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
                var arr = line.Split(' ');

                var m = long.Parse(arr[0]);
                var n = long.Parse(arr[1]);

                Console.Write("Case {0}: ", i);

                var dif = n - m;

                if(m != 1)
                {
                    dif++;
                }
                if(dif % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
            }
            Console.ReadLine();
        }
}