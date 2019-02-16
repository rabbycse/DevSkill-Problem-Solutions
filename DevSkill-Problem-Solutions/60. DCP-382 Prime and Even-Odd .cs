using System;

public class Test
{
	public static void Main()
        {
            while(true)
            {
                var line = Console.ReadLine();

                if(line == null)
                {
                    break;
                }
                var arr = line.Split(' ');

                var n = long.Parse(arr[0]);
                var m = long.Parse(arr[1]);

                if (n == 1 && m == 1)
                {
                    Console.WriteLine("Even");
                }
               else if((n == 1 && m > 1) || (n > 1 && m == 1))
                {
                    Console.WriteLine("Odd");
                }
               else
                {
                    Console.WriteLine("Even");
                }
            }
          
            Console.ReadLine();
        }
}