using System;

public class Test
{
	 public static void Main()
        {
            while(true)
            {
                var line = Console.ReadLine();

                if(line == null)
                {
                    break;
                }
                var arr = line.Split(' ');

                var a = Int32.Parse(arr[0]);
                var b = Int32.Parse(arr[1]);

                int r, c, s, i;
                s = 0;

                for(i = 0; i < b; i++)
                {
                    c = int.Parse(Console.ReadLine());
                    s += c;
                }

                r = 0;

                if(a%s == 0)
                {
                    r = a / s;
                }
                else
                {
                    r = (a / s) + 1;
                }

                if(r == 1)
                {
                    Console.WriteLine("Project will finish within 1 day.");
                }
                else
                {
                    Console.WriteLine("Project will finish within {0} days.", r);
                }
                
            }
          
            Console.ReadLine();
        }
}