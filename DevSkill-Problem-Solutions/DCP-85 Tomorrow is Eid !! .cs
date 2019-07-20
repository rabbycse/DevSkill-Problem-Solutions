using System;

public class Test
{
	public static void Main()
        {
            int n;
            n = int.Parse(Console.ReadLine());

            if (n == 29 || n == 30)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadLine();
        }
}