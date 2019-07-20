using System;

public class Test
{
	public static void Main()
        {
            int t;
            long N, A = 0, B = 0;
            long i;
            t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                N = long.Parse(Console.ReadLine());

                for (i = 1; i <= Math.Sqrt(N) + 1; i++)
                {
                    if (N % i == 0)
                    {
                        A = i;
                    }
                }
                B = (N / A);
                Console.WriteLine(Math.Abs(B - A));
            }
            Console.ReadLine();
        }
}