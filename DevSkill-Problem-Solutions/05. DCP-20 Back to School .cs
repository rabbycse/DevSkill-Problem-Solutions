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

                var a = Convert.ToInt32(n[0]);
                var b = Convert.ToInt32(n[1]);
                var r = Convert.ToDouble(n[2]);
                var c = Convert.ToInt32(n[3]);
                var d = Convert.ToInt32(n[4]);

                var e = Math.Sqrt(((a - c) * (a - c)) + ((b - d) * (b - d)));

                Console.Write("Case {0}: ", i);
            
                if (e > r)
                {
                    Console.WriteLine("Outside");
                }
                else if(e == r)
                {
                    Console.WriteLine("OnCircle");
                }
                else
                {
                    Console.WriteLine("Inside");
                }


            }
            Console.ReadLine();
        }
}