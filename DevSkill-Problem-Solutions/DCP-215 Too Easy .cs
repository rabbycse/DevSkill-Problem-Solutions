using System;

public class Test
{
	public static long mod(string s)
        {
            long sum = 0, MOD = 100000;
            for (int i = 0; i < s.Length; i++)
            {
                sum = sum * 10 + (s[i] - '0');
                sum %= MOD;
            }

            return sum;
        }

        public static void Main()
        {
            int T;
            T = int.Parse(Console.ReadLine());

            string s;
            for (int i = 0; i < T; i++)
            {
                s = Console.ReadLine();
                Console.WriteLine(mod(s));
            }

            Console.ReadLine();
        }
}