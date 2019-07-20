using System;

public class Test
{
	 public static void Main()
        {
            int t;

            t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                var  line = Console.ReadLine();

                var n = line.Split(' ');

                var x = Convert.ToDouble(n[0]);
                var y = Convert.ToDouble(n[1]);

                var result = x / y;

                Console.WriteLine("-{0}",result.ToString("0.00"));

            }
            Console.ReadLine();
        }
}