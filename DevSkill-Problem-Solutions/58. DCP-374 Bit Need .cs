using System;

public class Test
{
	public static void Main()
        {
            int t;
            ulong x, i;
            t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                i = 0;
                x = ulong.Parse(Console.ReadLine());

                if(x == 0)
                {
                    Console.WriteLine("1");
                }
                else
                {
                    while(x != 0)
                    {
                        if (x != 0)
                        {
                            i++;
                        }
                        x = x >> 1;
                    }
                    Console.WriteLine("{0}", i);
                }
            }
            Console.ReadLine();
        }
}