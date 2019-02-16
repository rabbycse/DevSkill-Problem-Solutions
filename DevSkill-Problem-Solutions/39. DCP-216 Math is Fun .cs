using System;

public class Test
{
	public static void Main()

        {
            int t, k;
            string s;
            t = int.Parse(Console.ReadLine());
            for (int i = 1; i <= t; i++)

            {

                s = Console.ReadLine();
                int sum = 0;
                for (k = 0; k < s.Length; k++)
                {
                    if (s[k] >= '0' && s[k] <= '9')
                    {
                        sum = sum + (s[k] - '0');
                    }
                }
                int g = (sum % 3);
                Console.WriteLine("Case {0}: {1}", i, 3 - g);
            }
            Console.ReadLine();         
        }
}