using System;

public class Test
{
	public static void Main()
        {
            int tc, pos, n;
            tc = int.Parse(Console.ReadLine());
            for (pos = 1; pos <= tc; pos++)
            {
                n = int.Parse(Console.ReadLine());

                Console.Write("Case {0}-> ", pos);

                if (n == 1 || n == 3)
                    Console.WriteLine("YES;");
                else
                    Console.WriteLine("NO;");
            }
            Console.ReadLine();
        }
}