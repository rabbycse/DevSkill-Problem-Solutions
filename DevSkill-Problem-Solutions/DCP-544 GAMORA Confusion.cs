using System;

public class Test
{
	public static void Main()
        {
            long t;

            t = long.Parse(Console.ReadLine());

            while(t-- > 0)
            {
                string str;
                str = Console.ReadLine();

                if (str[0] == 'Q')
                {
                    Console.Write("I am going to ask you this one time, where is Gamora?");
                }
                else if (str[0] == 'S')
                {
                    Console.Write("I will do you one better, who is Gamora?");
                }
                else if (str[0] == 'D')
                {
                    Console.Write("I will do you one better, why is Gamora?");
                }
                else
                {
                    Console.Write("What is Gamora?");
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
}