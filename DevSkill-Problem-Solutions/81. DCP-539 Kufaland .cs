using System;

public class Test
{
	public static void Main()
        {
            int tc;
            ulong n;

            tc = int.Parse(Console.ReadLine());

            while (tc-- > 0)
            {
                n = ulong.Parse(Console.ReadLine());

                if (n % 3 == 0)
                {
                    Console.WriteLine("1");
                }
                else if (n % 3 == 1)
                {
                    Console.WriteLine("2");
                }
                else
                {
                    Console.WriteLine("4");
                }
            }

            Console.ReadLine();
        }
}