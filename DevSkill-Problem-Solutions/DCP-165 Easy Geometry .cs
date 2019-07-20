using System;

public class Test
{
	public static void Main()
        {
            ulong tc,pos;

            tc = ulong.Parse(Console.ReadLine());

            for (pos = 1; pos <= tc; pos++)
            {
                var line = Console.ReadLine();
                var arr = line.Split(' ');
                var a = ulong.Parse(arr[0]);
                var b = ulong.Parse(arr[1]);

                Console.WriteLine("Case {0}: {1}", pos, 2 * a + b + 2 * b);
                
            }
            Console.ReadLine();
        }
}