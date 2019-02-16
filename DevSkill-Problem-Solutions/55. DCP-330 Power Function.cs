#define ONLINE_JUDGE
using System;

public class Test
{
	 public static void Main()
        {
            int t, n, rem;
            double res;

            t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                n = int.Parse(Console.ReadLine());

                res = Math.Pow(2, n);

                if ((n & 1) == 1)
                    Console.Write("-");
                else
                    Console.Write("+");

                while (res != 0)
                {
                    if (res < 10)
                    {
                        rem = (int)res % 10;
                        break;
                       
                    }

                     res /= 10;
                }

                Console.WriteLine((int)res);
            }
            Console.ReadLine();
        }
}