using System;

public class Test
{
	public static void Main()
        {
            int tc;
            string a, b;

            tc = int.Parse(Console.ReadLine());

            while (tc-- > 0)
            {
                string[] s = Console.ReadLine().Split(' ');
                a = Convert.ToString(s[0]);
                b = Convert.ToString(s[1]);

                if (a == "Dhaka")
                {
                    if (b == "Chittagong")
                    {
                        Console.WriteLine(200);
                    }
                    else if (b == "Rajshahi")
                    {
                        Console.WriteLine(300);
                    }
                    else if (b == "Kathmandu")
                    {
                        Console.WriteLine(3200);
                    }
                    else
                    {
                        Console.WriteLine(8200);
                    }

                }
                else if (a == "Chittagong")
                {
                    if (b == "Dhaka")
                    {
                        Console.WriteLine(200);
                    }
                    else if (b == "Rajshahi")
                    {
                        Console.WriteLine(500);
                    }
                    else if (b == "Kathmandu")
                    {
                        Console.WriteLine(3000);
                    }
                    else
                    {
                        Console.WriteLine(8000);
                    }
        
                }
                else if (a == "Rajshahi")
                {
                    if (b == "Dhaka")
                    {
                        Console.WriteLine(300);
                    }
                    else if (b == "Chittagong")
                    {
                        Console.WriteLine(500);
                    }
                    else if (b == "Kathmandu")
                    {
                        Console.WriteLine(3500);
                    }
                    else
                    {
                        Console.WriteLine(8500);
                    }
                   
                }
                else if (a == "Kathmandu")
                {
                    if (b == "Dhaka")
                    {
                        Console.WriteLine(3200);
                    }
                    else if (b == "Chittagong")
                    {
                        Console.WriteLine(3000);
                    }
                    else if (b == "Rajshahi")
                    {
                        Console.WriteLine(3500);
                    }
                    else
                    {
                        Console.WriteLine(11000);
                    }
    
                }
                else
                {
                    if (b == "Dhaka")
                    {
                        Console.WriteLine(8200);
                    }
                    else if (b == "Chittagong")
                    {
                        Console.WriteLine(8000);
                    }
                    else if (b == "Rajshahi")
                    {
                        Console.WriteLine(8500);
                    }
                    else
                    {
                        Console.WriteLine(11000);
                    }
                        
                }
            }
            Console.ReadLine();
        }
}