using System;
using System.Collections.Generic;

public class Test
{
	 public static void Main()
        {
            int tc;
            tc = int.Parse(Console.ReadLine());
            for (int i = 0; i < tc; i++)
            {
                int maxGoal = 1;
                string con = "";
                int groupNum = int.Parse(Console.ReadLine());
                for (int j = 0; j < groupNum; j++)
                {
                    var list = new Dictionary<string, int>();
                    string[] s = Console.ReadLine().Split(' ');
                    string country = s[0];
                    int goal = int.Parse(s[1]);
                    list.Add(country, goal);
                    foreach (var pair in list)
                    {
                        if (pair.Value > maxGoal)
                        {
                            maxGoal = pair.Value;
                            con = pair.Key;
                        }
                    }
                }
                Console.WriteLine("Winner: " + "\\" + con + "/");
            }

            Console.ReadLine();
        }
}