using System;

public class Test

{
    public static int NumberOfDigits(int n)
    {
        int count=0;

        if(n==0)
        {
            count=1;
        }
        else
        {
            while(n!=0)

            {
                n=n/10;
                count++;
            }

        }
        return count;

    }
    
    public static void Main()

    {
        int T = Convert.ToInt32(Console.ReadLine());
        for(int i=0; i<T; i++)
        {
            int X = Convert.ToInt32(Console.ReadLine());
            int L = NumberOfDigits(X);
            Console.WriteLine(L);
        }
        Console.ReadLine();
    }

}
