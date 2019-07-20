using System;

public class Test
{
	public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long sum = 0;

            for (int i = 1; i < n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }

            Console.WriteLine(sum);

          Console.ReadLine();
        }
}