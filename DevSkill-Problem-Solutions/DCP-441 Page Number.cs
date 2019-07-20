using System;

public class Test
{
	public static void Main()
        {
            int t;
            t = int.Parse(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {
                ulong sum, c;
                var line = Console.ReadLine();

                var arr = line.Split(' ');
                var n = ulong.Parse(arr[0]);
                var k = ulong.Parse(arr[1]);

                sum=n;

                Console.Write("Case {0}: ", i);

                if(sum >= k)
                {
                    Console.WriteLine("1");
                }
                else
                {
                    c = 1;
                    while(true)
                    {
                        ++c;
                        n <<= 1;
                        sum += n;

                        if(sum >= k)
                        {
                            break;
                        }
                    }
                    Console.WriteLine("{0}", c);
                }
            }
            Console.ReadLine();
        }
}