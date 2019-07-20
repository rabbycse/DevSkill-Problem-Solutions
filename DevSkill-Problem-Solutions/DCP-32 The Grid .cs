using System;

public class Test
{
	public static void Main()
        {
            int t;

            t = int.Parse(Console.ReadLine());

            for (int i=1; i<=t; i++)
            {
                var line = Console.ReadLine();
                var arr = line.Split(' ');

                var a = Convert.ToInt32(arr[0]);
                var b = Convert.ToInt32(arr[1]);
                var c = Convert.ToInt32(arr[2]);
                var d = Convert.ToInt32(arr[3]);

                Console.WriteLine("Case {0}: {1}", i, (Math.Abs(a - c) + Math.Abs(b - d)));

            }
            Console.ReadLine();

        }         
}