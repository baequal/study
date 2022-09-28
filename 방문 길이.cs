using System;
using System.Collections.Generic;

namespace Codingstudy
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "ULURRDLLU";

            Program p = new Program();

            int output = p.solution(input1);
            Console.WriteLine(output);
        }
         //    dirs	          answer
        //"ULURRDLLU"	7
        public int solution(string dirs)
        {
            int answer = 0;
            int[] start = { 0, 0 };
            List<string> temp = new List<string>();
            string way = "";

            for (int i = 0; i < dirs.Length; i++)
            {
                way = "";
                if (dirs[i] == 'U' && start[1] < 5)
                {
                    way = start[0].ToString() + start[0].ToString() + start[1].ToString() + (start[1] + 1).ToString();
                    if (temp.Exists(x => x == way) == false)
                    {
                        temp.Add(way);
                        answer++;
                    }
                    start[1] += 1;

                }
                else if (dirs[i] == 'D' && start[1] > -5)
                {
                    way = start[0].ToString() + start[0].ToString() + (start[1] - 1).ToString() + start[1].ToString();
                    if (temp.Exists(x => x == way) == false)
                    {
                        temp.Add(way);
                        answer++;
                    }
                    start[1] -= 1;
                }
                else if (dirs[i] == 'R' && start[0] < 5)
                {
                    way = start[0].ToString() + (start[0] + 1).ToString() + start[1].ToString() + start[1].ToString();
                    if (temp.Exists(x => x == way) == false)
                    {
                        temp.Add(way);
                        answer++;
                    }
                    start[0] += 1;
                }
                else if (dirs[i] == 'L' && start[0] > -5)
                {
                    way = (start[0] - 1).ToString() + start[0].ToString() + start[1].ToString() + start[1].ToString();
                    if (temp.Exists(x => x == way) == false)
                    {
                        temp.Add(way);
                        answer++;
                    }
                    start[0] -= 1;
                }
            }

            return answer;
        }
    }
}
