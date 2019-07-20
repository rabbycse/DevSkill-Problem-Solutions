using System;

public class Test
{
	 public static void Main()
        {

            long tc;

            tc = long.Parse(Console.ReadLine());

            while (tc-- > 0)
            {
                var line = Console.ReadLine();
                var arr = line.Split(' ');

                var a = long.Parse(arr[0]);
                var b = long.Parse(arr[1]);
                var c = long.Parse(arr[2]);

                Console.WriteLine((a * 10) + (b * 50) + (c * 100));
            }
            Console.ReadLine();
        }
}