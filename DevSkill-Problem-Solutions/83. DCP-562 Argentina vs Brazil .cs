using System;

public class Test
{
	public static void Main()
        {
            int tc;
            tc = int.Parse(Console.ReadLine());
            while(tc-- > 0)
            {
                string[] s = Console.ReadLine().Split(' ');
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);

                if(a>b)
                {
                    Console.WriteLine("Argentina {0} - {1} Brazil", a, b);
                }
                else
                {
                    Console.WriteLine("Brazil {0} - {1} Argentina", b, a);
                }
            }

            Console.ReadLine();
        }
}