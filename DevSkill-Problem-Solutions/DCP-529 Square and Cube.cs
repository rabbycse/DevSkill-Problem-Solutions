using System;

public class Test
{
	public static void Main()
        {
            int tc, n, i, sq, cb;

            tc = int.Parse(Console.ReadLine());

            while (tc-- > 0)
            {
                n = int.Parse(Console.ReadLine());

                sq = cb = 0;

                for (i = 1; i * i <= n; i++)
                {
                    if (i * i == n)
                        sq = i;
                    if (i * i * i == n)
                        cb = i;

                    if (sq > 0 && cb > 0)
                        break;
                }

                if (sq > 0 && cb > 0)
                {
                    Console.WriteLine("Both");
                }
                else if (sq > 0)
                {
                    Console.WriteLine("Perfect Square");
                }
                else if (cb > 0)
                {
                    Console.WriteLine("Perfect Cube");
                }
                else
                {
                    Console.WriteLine("None");
                }
            }
            Console.ReadLine();
        }
}