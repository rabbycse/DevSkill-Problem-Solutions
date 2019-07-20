using System;

public class Test
{
	public static long recur(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                if (b > c)
                {
                    return recur(a - (a - b), b, c);
                }
                else
                {
                    return recur(a - (a - c), b, c);
                }
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    return recur(a, b - (b - a), c);
                }
                else
                {
                    return recur(a, b - (b - c), c);
                }
            }
            else if (c > a && c > b)
            {
                if (a > b)
                {
                    return recur(a, b, c - (c - a));
                }
                else
                {
                    return recur(a, b, c - (c - b));
                }
            }
            return a + b + c;
        }

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
                var c = Int32.Parse(arr[2]);

                
                Console.WriteLine(recur(a,b,c));


            }
          
            Console.ReadLine();
        }
}