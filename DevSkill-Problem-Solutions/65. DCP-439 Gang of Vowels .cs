using System;

public class Test
{
	public static void Main()
        {
            int tc, pos,len, i, k;
            bool val;
            string str;

            tc = int.Parse(Console.ReadLine());

            for (pos = 1; pos <= tc; pos++)
            {
                len = int.Parse(Console.ReadLine());
                str = Console.ReadLine();

                k = 0;
                val = false;

                for (i = 0; i < len; i++)
                {
                    if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                        val = true;

                    if ((!(str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u') || i == len - 1) && val)
                    {
                        ++k;
                        val = false;
                    }
                }

                if (len == k)
                    k = 0;

                Console.WriteLine("Case {0}: {1}", pos, k);
            }
            Console.ReadLine();
        }
}