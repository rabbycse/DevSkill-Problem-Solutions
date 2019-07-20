using System;

public class Test
{
	public static void Main()
        {
            int tc, i = 0, j = 0, m, n = 0, len;
            string str;

            tc = int.Parse(Console.ReadLine());
            
            while (tc-- > 0)
            {
                str = Console.ReadLine();
                len = str.Length;
                j++;
                for (m = 0; m < len; m++)
                {
                    if (str[m] == '.')
                    {
                        n = m;
                        break;
                    }
                }

                Console.Write("Case #{0} -> ", j);
                Console.Write(str[0]);
         
                for (i = 1; i < n; i++)
                {
                    if (str[i] >= 65 && str[i] <= 90)
                    {
                        Console.Write(" " + str[i]);
                    }
                    else
                    {
                        Console.Write(str[i]);
                    }
                }
                Console.WriteLine();


            }
            Console.ReadLine();
        }
}