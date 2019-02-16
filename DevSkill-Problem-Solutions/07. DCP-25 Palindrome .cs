using System;

public class Test
{
	public static void Main()
        {
            int t;

            t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string string1, rev;
                string1 = Console.ReadLine();
                char[] ch = string1.ToCharArray();

                Array.Reverse(ch);
                rev = new string(ch);

                bool b = string1.Equals(rev, StringComparison.OrdinalIgnoreCase);
                if (b == true)
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