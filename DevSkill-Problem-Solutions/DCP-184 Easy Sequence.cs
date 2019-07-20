using System;

public class Test
{
	public static void Main()
        {
            long t;

            t = long.Parse(Console.ReadLine());

            while(t-- > 0)
            {
                long n, i, a = 1, b = 3, sum;
                n = long.Parse(Console.ReadLine());

                for( i = 1; i <= n; i++)
                {
                    if(i == n)
                    {
                        Console.WriteLine("{0}", a);
                    }
                    sum = a + b;
                    a = b;
                    b = sum;

                }

            }
            Console.ReadLine();
        }
}