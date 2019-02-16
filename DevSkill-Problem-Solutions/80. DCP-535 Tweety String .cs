using System;

public class Test
{
	public static void Main()
        {
            int tc, i, len, sum;
            string str;

            tc = int.Parse(Console.ReadLine());

            while (tc-- > 0)
            {
                str = Console.ReadLine();
                len = str.Length;
                sum = 0;

                for (i = 0; i<len; i++)
                {
                    sum += str[i];
                }

                if (sum % 20 == 0)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
                 
            }
            Console.ReadLine();
        }
}