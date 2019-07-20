using System;

public class Test
{
	 public static void Main()

        {
            long t, n;
            t = long.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                n = long.Parse(Console.ReadLine());
                if (n == 1)
                {
                    Console.WriteLine("{0} 000", n);
                }
                else if (n == 2)
                {
                    Console.WriteLine("{0} 010", n);
                }
                else
                {
                    Console.WriteLine("{0} 110", n);
                }
           
            }
            Console.ReadLine();         
        }
}