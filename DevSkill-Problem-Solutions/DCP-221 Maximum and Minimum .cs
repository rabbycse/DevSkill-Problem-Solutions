using System;
using System.Linq;

public class Test
{
	public static void Main()
        {
            int tc;

            tc = Convert.ToInt32(Console.ReadLine());
            ConsoleKeyInfo keyInfo;

            for (int p = 1; p <= tc; p++)
            {
                while ((keyInfo = Console.ReadKey()).Key != ConsoleKey.Enter)
                {
                    string s = Console.ReadLine();
                    int[] input = s.Split(' ').Select(t => Convert.ToInt32(t)).ToArray();

                    for (int i = 0; i < input.Length; i++)
                    {
                        int min = i;

                        for (int j = i + 1; j < input.Length; j++)
                        {
                            if (input[j] < input[min])
                            {
                                min = j;
                            }
                        }
                        if (min != i)
                        {
                            int temp = input[min];
                            input[min] = input[i];
                            input[i] = temp;
                        }
                    }
                    Console.WriteLine("Case {0}: Among {1} numbers {2} is maximum and {3} is minimum", p, input.Length, input[input.Length - 1], input[0]);
                    break;
                }
            }

            Console.ReadLine();
        }
}