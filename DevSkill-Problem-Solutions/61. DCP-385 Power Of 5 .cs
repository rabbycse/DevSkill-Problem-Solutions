using System;

public class Test
{
	public static void Main()
        {
            int t;
            ulong n;
            t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                n = ulong.Parse(Console.ReadLine());
                if (n == 1 || n == 5 || (n % 100) == 25)
                {
                    Console.WriteLine("YES");
                }          
                else
                {
                    Console.WriteLine("NO");
                }
                    
            }
            Console.ReadLine();
        }
}