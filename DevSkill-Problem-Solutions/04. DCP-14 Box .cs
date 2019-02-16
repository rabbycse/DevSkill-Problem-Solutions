using System;

public class Test
{
	public static void Main()
        {
            int t;

            t = int.Parse(Console.ReadLine());

            for (int i=0; i<t; i++)
            {
                var line = Console.ReadLine();

                var n = line.Split(' ');

                var a = Convert.ToDouble(n[0]);
                var b = Convert.ToDouble(n[1]);
                var c = Convert.ToDouble(n[2]);

                var s = Math.Sqrt(((a * a) + (b * b)) + (c * c));

                Console.WriteLine("{0}", s.ToString("0.00"));
            }
            Console.ReadLine();
        }
}