using System;

public class Test
{
	public static void Main()

        {
            int tc;
            string str;

            tc = int.Parse(Console.ReadLine());

            while (tc-- > 0)
            {
                str = Console.ReadLine();

                if (str[0] == '0')
                {
                    Console.Write("88{0} ", str);

                    if (str[2] == '1')
                    {
                        Console.WriteLine("Citycell");
                    }
                    else if (str[2] == '5')
                    {
                        Console.WriteLine("Teletalk");
                    }
                    else if (str[2] == '6')
                    {
                        Console.WriteLine("Airtel");
                    }
                    else if (str[2] == '7')
                    {
                        Console.WriteLine("Grameenphone");
                    }
                    else if (str[2] == '8')
                    {
                        Console.WriteLine("Robi");
                    }
                    else
                    {
                        Console.WriteLine("Banglalink");
                    }

                }
                else
                {
                    Console.Write("{0} ", str);

                    if (str[4] == '1')
                    {
                        Console.WriteLine("Citycell");
                    }
                    else if (str[4] == '5')
                    {
                        Console.WriteLine("Teletalk");
                    }
                    else if (str[4] == '6')
                    {
                        Console.WriteLine("Airtel");
                    }
                    else if (str[4] == '7')
                    {
                        Console.WriteLine("Grameenphone");
                    }
                    else if (str[4] == '8')
                    {
                        Console.WriteLine("Robi");
                    }
                    else
                    {
                        Console.WriteLine("Banglalink");
                    }

                }
            }
            Console.ReadLine();         
        }
}