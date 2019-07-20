using System;

public class Test
{
	const int MAX = 100005;

        public static void Main()
        {
            ulong tc, n, i, a, b, k;
            ulong[] arr = new ulong[MAX];

            for (i = 1; i < MAX; i++)
            {
                a = i * i;
                b = i * i * i;

                if (isSqnm(a + b))
                    arr[i] = arr[i - 1] + 1;
                else
                    arr[i] = arr[i - 1];
            }

            tc = ulong.Parse(Console.ReadLine());

            while (tc-- > 0)
            {
                string[] s = Console.ReadLine().Split(' ');
                n = ulong.Parse(s[0]);
                k = ulong.Parse(s[1]);

                if (arr[n] == k)
                {
                    Console.WriteLine("I am married now");
                }
                else
                {
                    Console.WriteLine("Baba amar ki biye hobe na");
                }
  
            }
            Console.ReadLine();
        }

        public static bool isSqnm(ulong n)
        {
            ulong r = (ulong)Math.Sqrt(n);

            if (r * r == n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
}