using System;

public class Test
{
	public static void Main()
        {
            int t;

            t = int.Parse(Console.ReadLine());

            for (int i = 1; i <= t; i++)
            {
                int e;
              
                string[] s = Console.ReadLine().Split(' ');
                var a = Convert.ToDouble(s[0]);
                var b = Convert.ToDouble(s[1]);
                var c = Convert.ToDouble(s[2]);

                string[] s2 = Console.ReadLine().Split(' ');
                var a1 = Convert.ToDouble(s2[0]);
                var b1 = Convert.ToDouble(s2[1]);
                var c1 = Convert.ToDouble(s2[2]);

                e = 0;

                if ((a > a1 && a > b1 && a > c1)
                    && (b > a1 && b > b1 && b > c1)
                    && (c > a1 && c > b1 && c > c1))
                {
                    e = 1;
                }
                else if ((a1 > a && a1 > b && a1 > c)
                    && (b1 > a && b1 > b && b1 > c)
                    && (c1 > a && c1 > b && c1 > c))
                {
                    e = 2;
                }
                Console.Write("Case {0}: ", i);

                if (e == 0)
                {
                    Console.WriteLine("Both can win");
                }
                else if (e == 1)
                {
                    Console.WriteLine("Swapnil wins");
                }
                else
                {
                    Console.WriteLine("Shibli wins");
                }

            }
            Console.ReadLine();
        }
}