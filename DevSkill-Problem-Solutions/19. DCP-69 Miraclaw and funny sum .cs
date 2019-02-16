using System;

public class Test
{
	public static void Main()
        {
            int tc;
            tc = Convert.ToInt32(Console.ReadLine());
            while (tc-- > 0)
            {
                int n;
                n = Convert.ToInt32(Console.ReadLine());
                int a = 0;
                int b = 0;

                int[] arr = new int[n];
                string[] s = Console.ReadLine().Split(' ');

                for ( int i = 0; i < n; i++)
                {
                    arr[i] = Convert.ToInt32(s[i]);
                    a += arr[i];
                    if (arr[i] >= i)
                    {
                        b += arr[i] - i;
                    }

                }
                Console.WriteLine(a - b);
            }
            Console.ReadLine();
        }
}