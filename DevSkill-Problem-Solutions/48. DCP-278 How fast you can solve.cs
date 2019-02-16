using System;

public class Test
{
	public static void Main()
        {
            int t;

            t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                var line = Console.ReadLine();
                var arr = line.Split(' ');
                var a = long.Parse(arr[0]);
                var b = long.Parse(arr[1]);
                var c = long.Parse(arr[2]);

                Console.WriteLine((b + c) - a);
            }
            Console.ReadLine();

        }
}