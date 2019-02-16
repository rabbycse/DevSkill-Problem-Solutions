using System;

public class Test
{
	public static long ch(int n, int k)
        {
            long r = 1;
            int p = k, i;
            if (k > n / 2)
                k = n - k;
            for (i = 0; i < k; i++)
            {
                r *= (n - i);
                r /= (i + 1);
            }
            return r;
        }

        public static void Main()
        {
            int k, a, b;
            k = int.Parse(Console.ReadLine());
            while (k-- > 0)
            {
                string[] s = Console.ReadLine().Split(' ');
                a = int.Parse(s[0]);
                b = int.Parse(s[1]);
                Console.WriteLine(ch(a + b, b));
            }

            Console.ReadLine();
        }

}