using System;

public class Test
{
	 public static void Main()
        {
            int t;
            t = Convert.ToInt32(Console.ReadLine());

            for (int p = 0; p < t; p++)
            {
                var line = Console.ReadLine();
                var ar = line.Split(',');
                var a = Convert.ToInt64(ar[0]);
                var b = Convert.ToInt32(ar[1]);

                Console.WriteLine(Change(a, b));
            
            }
            Console.ReadLine();
        }

        public static string Change(long dnum, int r)
        {
            const int BigInteger = 64;
            const string str = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (r < 2 || r > str.Length)
                throw new ArgumentException(str.Length.ToString());

            if (dnum == 0)
                return "0";

            int i = BigInteger - 1;
            long bnum = Math.Abs(dnum);
            char[] ch = new char[BigInteger];

            while (bnum != 0)
            {
                int reminder = (int)(bnum % r);
                ch[i--] = str[reminder];
                bnum = bnum / r;
            }

            string result = new string(ch, i + 1, BigInteger - i - 1);
            if (dnum < 0)
            {
                result = "-" + result;
            }

            return result;
        }
}