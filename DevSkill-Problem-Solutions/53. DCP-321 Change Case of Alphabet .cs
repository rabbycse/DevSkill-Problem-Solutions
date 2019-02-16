using System;

public class Test
{
	public static void Main()
        {
            int tc;
            tc = int.Parse(Console.ReadLine());

            while (tc-- > 0)
            {
                string str;
                char[] arr;
                int l, i;
                l = 0;
                char ch;
                
                str = Console.ReadLine();
                l = str.Length;
                arr = str.ToCharArray(0, l); 

                for (i = 0; i < l; i++)
                {
                    ch = arr[i];
                    if (Char.IsLower(ch))
                    {
                        Console.Write(Char.ToUpper(ch));
                    }
                    else
                    {
                        Console.Write(Char.ToLower(ch));
                    }
                         
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
}