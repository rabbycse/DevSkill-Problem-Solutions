using System;

public class Test
{
	 public static void Main()
        {
            int t;

            t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                var line = Console.ReadLine();
                var arr = line.Split(' ');

                var a = Convert.ToString(arr[0]);
                var b = Convert.ToString(arr[1]);
                var c = Convert.ToString(arr[2]);
                var d = Convert.ToInt32(arr[3]);

                if (b == "nobo")
                {
                    Console.WriteLine("Shuva naya barsha {0}", d + 650);
                }
                else
                {
                    Console.WriteLine("Shuvo nobo borsho {0}", d - 650);
                }

            }
            Console.ReadLine();
        }
}