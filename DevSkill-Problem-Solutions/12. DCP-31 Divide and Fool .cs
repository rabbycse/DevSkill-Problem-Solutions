using System;

public class Test
{
	public static void Main()
        {
            int t;

            t = int.Parse(Console.ReadLine());

            for (int i=1; i<=t; i++)
            {
                int pc, x;

                var line = Console.ReadLine();
                var arr = line.Split(' ');

                var a = Convert.ToInt32(arr[0]);
                var b = Convert.ToInt32(arr[1]);
                var c = Convert.ToInt32(arr[2]);

                Console.Write("{0}", (a / b));

                pc = 0;
                Console.Write(".");
                a %= b;

                while(pc < c)
                {
                    a *= 10;
                    x = a / b;
                    a %= b;
                    Console.Write("{0}", x);
                    pc++;
                }
                Console.WriteLine();

            }
            Console.ReadLine();

        }         
}