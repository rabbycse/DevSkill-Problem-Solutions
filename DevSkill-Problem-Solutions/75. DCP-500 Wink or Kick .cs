using System;

public class Test
{
	public static void Main()
        {
            int tc;
            ulong a, b;

            tc = int.Parse(Console.ReadLine());

            while (tc-- > 0)
            {
                string[] s = Console.ReadLine().Split(' ');
                a = ulong.Parse(s[0]);
                b = ulong.Parse(s[1]);
                
                if(b == 0)
                {
                    Console.WriteLine(":kick:");
                    continue;
                }

                if (a % b == 0)
                {
                    Console.WriteLine(":wink:");
                }
                else
                {
                    Console.WriteLine(":kick:");
                }
                                                       
            }

            Console.ReadLine();
        }
}