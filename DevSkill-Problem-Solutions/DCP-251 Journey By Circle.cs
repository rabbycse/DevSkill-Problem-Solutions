using System;

public class Test
{
	public static void Main()
        {
            ulong tc, i;

            tc = ulong.Parse(Console.ReadLine());

            for (i = 1; i <= tc; i++)
            {
                var line = Console.ReadLine();
                var arr = line.Split(' ');
                var a = ulong.Parse(arr[0]);
                var b = ulong.Parse(arr[1]);

                a <<= 1;
                b <<= 1;

                Console.WriteLine((a * b) / GCD(a, b));
            }
            Console.ReadLine();

        }

        public static ulong GCD(ulong a, ulong b)
        {
            if (b == 0)
                return a;
            else
                return GCD(b, a % b);
        }
}