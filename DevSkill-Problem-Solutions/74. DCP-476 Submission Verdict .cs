using System;

public class Test
{
	 public static void Main()
        {
            long t;

            t = long.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                string str;
                str = Console.ReadLine();

                if (str == "ac")
                {
                    Console.WriteLine("Accepted");
                }                  
                else if (str == "wa")
                {
                    Console.WriteLine("Wrong Answer");
                }                  
                else if (str == "rte")
                {
                    Console.WriteLine("Run Time Error");
                }                 
                else
                {
                    Console.WriteLine("Time Limit Exceeded");
                }
                    
            }
            Console.ReadLine();
        }
}