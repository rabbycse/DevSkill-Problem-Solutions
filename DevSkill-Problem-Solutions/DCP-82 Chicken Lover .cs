#define ONLINE_JUDGE
using System;

public class Test
{
	 public static void Main()
        {
            int t;

            t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int n;
                n = int.Parse(Console.ReadLine());

                if(n < 120)
                {
                    Console.WriteLine("Naughty Boy Sifat");
                }
                else
                {
                    Console.WriteLine("Good Boy Sifat");
                }

            }
            Console.ReadLine();
        }
}