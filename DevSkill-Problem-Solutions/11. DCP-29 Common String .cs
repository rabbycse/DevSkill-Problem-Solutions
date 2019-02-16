using System;

public class Test
{
	 public static int F(string s, string m)
        {
            int r = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < m.Length; j++)
                {
                    if (s[i] == m[j])
                    {
                        int t = i + 1, tt = j + 1, c = 1;
                        while (t < s.Length && tt < m.Length)
                        {
                            if (s[t] == m[tt]) c++;
                            else break;
                            t++;
                            tt++;
                        }
                        r = Math.Max(r, c);
                    }
                }
            }
            return r;

        }

        public static void Main()
        {
            int tc;

            tc = int.Parse(Console.ReadLine());

            for (int p = 1; p <= tc; p++)
            {
                var line = Console.ReadLine();
                var arr = line.Split(' ');

                var s = Convert.ToString(arr[0]);
                var m = Convert.ToString(arr[1]);

                Console.WriteLine("Case {0}: {1}", p, F(s, m));
            }
            Console.ReadLine();
        }
}