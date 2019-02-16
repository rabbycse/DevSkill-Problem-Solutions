using System;

public class Test
{
	public static void Main()
        {
            int i, j, k, temp, tc, t, c, it, a;
           
            tc = int.Parse(Console.ReadLine());

            for (t = 1; t <= tc; t++)
            {
                a = 0;
                c = int.Parse(Console.ReadLine());
                it = int.Parse(Console.ReadLine());

                int[] p = new int[it];
                string[] s = Console.ReadLine().Split(' ');
                for (i = 0; i < it; i++) p[i] = Convert.ToInt32(s[i]);
                Console.Write("Case {0}: ", t);
                for (i = 0; i < it - 2; i++)
                {
                    for (j = i + 1; j < it - 1; j++)
                    {
                        temp = p[i] + p[j];
                        for (k = j + 1; k < it; k++)
                        {
                            temp += p[k];
                            if (temp == c)
                            {
                                a = 1;
                                Console.WriteLine("{0} {1} {2}", i + 1, j + 1, k + 1);
                                break;
                            }
                            temp -= p[k];
                        }
                        if (a == 1) break;
                    }
                    if (a == 1) break;
                }
                if (a != 1) Console.WriteLine("You are out of your luck!");
            }
            Console.ReadLine();
        }
}