using System;

public class Test
{
	 public static void Main()
        {
            int t;

            t = int.Parse(Console.ReadLine());

            for (int i = 1; i <= t; i++)
            {
                var line = Console.ReadLine();
                var n = line.Split(' ');

                var a = Convert.ToDouble(n[0]);
                var b = Convert.ToDouble(n[1]);

                var c = Math.Floor(Math.Sqrt(2) * a);
                b = Math.Floor(b);

                if(c == b)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }

            }
            Console.ReadLine();
        }
}