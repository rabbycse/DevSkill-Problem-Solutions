using System;

public class Test
{
	 public static void Main()
        {
            int t, p;
            string s;

            t = int.Parse(Console.ReadLine());

            for (int i = 1; i <= t; i++)
            {
                p = 1;
                s = Console.ReadLine();

                for(int j=0; j<s.Length; j++)
                {
                    if(s[j] == 'r')
                    {
                        p = 0;
                        break;
                    }
                }
                if(p == 1)
                {
                    Console.WriteLine("Vely easy");
                }
                else
                {
                    Console.WriteLine("Not vely easy");
                }

            }
            Console.ReadLine();
        }
}