using System;

public class Test
{
	public static void Main()

        {
            ulong tc, n, pos, i, x, y;

            tc = ulong.Parse(Console.ReadLine());

            for (pos = 1; pos <= tc; pos++)
            {
                n = ulong.Parse(Console.ReadLine());

                x = y = 18446744073709551615;

                for (i = 1; i <= n; i++)
                {
                    var line = Console.ReadLine();
                    var arr = line.Split(' ');
                    var a = ulong.Parse(arr[0]);
                    var b = ulong.Parse(arr[1]);

                    if (a < x)
                    {
                        x = a;
                        y = b;
                    }
                    else if (a == x && b < y)
                        y = b;
                }
                Console.WriteLine("Case {0}: {1} {2}", pos, x, y);
            }
            Console.ReadLine();
            
        }
}