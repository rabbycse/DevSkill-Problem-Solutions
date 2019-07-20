using System;

public class Test
{
	public static void Main()

        {
            long t, caseno = 0;
            t = long.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                var line = Console.ReadLine();
                var arr = line.Split(' ');

                var r = long.Parse(arr[0]);
                var c = long.Parse(arr[1]);

                long dim = 0, dam;

                while (r >= 1 && c >= 1)
                {
                    dim = dim + r * c;
                    r--;
                    c--;
                }
                dam = dim * 15;
                Console.WriteLine("Case {0}: {1}", ++caseno, dam);
            }
            Console.ReadLine();         
        }
}