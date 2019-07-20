using System;

public class Test
{
	public static void Main()
        {
            int t, len, i, val;
            string str;
            t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                str = Console.ReadLine();
                len = str.Length;

                val = -1;

                for (i = 0; i < len; i++)
                    if (val < (int)(str[i]))
                        val = str[i];
                
                Console.WriteLine("{0}", (char)(val));

            }
            Console.ReadLine();
        }
}