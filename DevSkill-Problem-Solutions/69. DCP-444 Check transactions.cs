using System;

public class Test
{
	 public static void Main()
        {
            long tc, a, b, n, val, sum;
            string str;
            bool k;

            tc = long.Parse(Console.ReadLine());

            while (tc-- > 0)
            {
                a = long.Parse(Console.ReadLine());
                b = long.Parse(Console.ReadLine());
                n = long.Parse(Console.ReadLine());

                k = true;
                sum = a;

                while (n-- > 0)
                {
                    string[] s = Console.ReadLine().Split(' ');
                    str = Convert.ToString(s[0]);
                    val = long.Parse(s[1]);

                    if (string.Compare(str, "in") == 0)
                    {
                        sum += val;
                    }
                    else
                    {
                        sum -= val;
                    }

                    if (sum < 0)
                    {
                        k = false;
                    }
                       
                }

                if (!k || sum != b)
                {
                    Console.WriteLine("no");
                }
                else
                {
                    Console.WriteLine("yes");
                }
            
            }
            Console.ReadLine();
        }
}