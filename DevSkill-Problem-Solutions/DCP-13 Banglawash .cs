using System;

public class Test
{
	 public static void Main()
        {
            int t;

            t = int.Parse(Console.ReadLine());

            for (int i=1; i<=t; i++)
            {
                int e = 0;
                for(int j = 0; j < 2; j++)
                {
                    var line = Console.ReadLine();
                    var n = line.Split(' ');

                    var a = Convert.ToInt32(n[0]);
                    var b = Convert.ToInt32(n[1]);
                    var c = Convert.ToInt32(n[2]);
                    var d = Convert.ToInt32(n[3]);

                    if((a+b)>(c+d))
                    {
                        e++;
                    }
                }
                if(e == 2)
                {
                    Console.WriteLine("Banglawash");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }
            Console.ReadLine();
        }
}