using System;

public class Test
{
	 public static void Main()
        {
            int t; ;

            t = int.Parse(Console.ReadLine());

            for (int i = 1; i <= t; i++)
            {
                long n;
                n = long.Parse(Console.ReadLine());

                if(n % 2 == 0)
                {
                    Console.WriteLine("1");
                }
                else
                {
                    Console.WriteLine("9");
                }

            }
            Console.ReadLine();
        }
}