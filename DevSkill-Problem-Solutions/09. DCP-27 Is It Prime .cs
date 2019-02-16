using System;

public class Test
{
	public static void Main()
        {
            int T, num;

            T = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                num = Convert.ToInt32(Console.ReadLine());

                bool isPrime = true;

                for (int j = 2; j <= num / 2; j++)
                {
                    if (num % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime && num > 1)
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