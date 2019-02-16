using System;

public class Test
{
        public static void Main()
        {
            int t;

            t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string str, reverse = "";
                int Length = 0;

                str = Console.ReadLine();

                Length = str.Length - 1;
                while (Length >= 0)
                {
                    reverse = reverse + str[Length];
                    Length--;
                }

                Console.WriteLine("{0}", reverse);

            }
            Console.ReadLine();
        }
}