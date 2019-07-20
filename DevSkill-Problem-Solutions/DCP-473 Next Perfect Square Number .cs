using System;

public class Test
{
	public static void Main()
        {
            int tc;
            long n, r;

            tc = int.Parse(Console.ReadLine());

            while (tc-- > 0)
            {
                n = long.Parse(Console.ReadLine());

                r = (long)Math.Floor(Math.Sqrt((double)(n))) + 1;

                Console.WriteLine(r * r);
            }
            Console.ReadLine();
        }

}