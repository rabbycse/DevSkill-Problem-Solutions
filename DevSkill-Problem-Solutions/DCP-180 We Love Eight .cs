using System;

public class Test
{
	public static void Main()
        {
            int tc;
            string s;

            tc = int.Parse(Console.ReadLine());

            while (tc-- > 0)
            {
                s = Console.ReadLine();

                int l = s.Length;

                int n = s[l - 3] * 100 + s[l - 2] * 10 + s[l - 1];

                if (n % 8 == 0)

                {

                    Console.WriteLine("YES");

                    if (s[0] == 'A')
                    {
                        Console.WriteLine("1");
                    } 
                    else
                    {
                        Console.WriteLine("0");
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            Console.ReadLine();
        }
}