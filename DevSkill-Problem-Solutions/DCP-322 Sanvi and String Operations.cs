using System;

public class Test
{
	public static bool check(string a, string b)
        {
            if (a.Length != b.Length)
                return false;

            char[] charX = a.ToCharArray();
            Array.Sort(charX);

            char[] charY = b.ToCharArray();
            Array.Sort(charY);

            for (int i = 0; i < charX.Length; i++)
                if (charX[i] != charY[i])
                    return false;

            return true;
        }

        public static void Main()
        {
            int tc;
            tc = int.Parse(Console.ReadLine());

            for (int i = 0; i < tc; i++)
            {
                string a, b;
                string[] s = Console.ReadLine().Split(' ');

                a = Convert.ToString(s[0]);
                b = Convert.ToString(s[1]);

                if (check(a, b))
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