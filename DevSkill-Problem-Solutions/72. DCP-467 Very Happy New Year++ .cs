using System;

public class Test
{
	public static void Main()
        {
            long t;

            t = long.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int len, i, k;
                string str;
                str = Console.ReadLine();

                len = str.Length;
                k = 2018;

                for (i = len - 1; ; i--)
                {
                    if (str[i] == 'r')
                        break;
                    else if (str[i] == '+')
                        ++k;
                }
                Console.WriteLine("Happy New Year-{0}", k);

            }
            Console.ReadLine();
        }
}