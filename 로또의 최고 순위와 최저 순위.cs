using System;
using System.Collections.Generic;

namespace Codingstudy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = { 44, 1, 0, 0, 31, 25 };
            int[] input2 = { 31, 10, 45, 1, 6, 19 };

            Program p = new Program();

            int[] output = p.solution(input1, input2);
            Console.WriteLine(output);
        }
        //[44, 1, 0, 0, 31, 25]	[31, 10, 45, 1, 6, 19]	[3, 5]
        //output 최고순위, 최저순위
        public int[] solution(int[] lottos, int[] win_nums)
        {
            int[] answer = { 0,0} ;
            //7-일치한 숫자 = 등수

            for (int i = 0; i < lottos.Length; i++)
            {
                if (lottos[i] == 0)
                {
                    answer[0] += 1;
                }
                else
                {
                    if (Array.IndexOf(win_nums, lottos[i]) != -1)
                    {
                        answer[1] += 1;
                        answer[0] += 1;
                    }
                }
            }
            if (answer[0] > 1)
            {
                answer[0] = 7 - answer[0];
            }
            else
            {
                answer[0] = 6;
            }
            if (answer[1] > 1)
            {
                answer[1] = 7 - answer[1];
            }
            else
            {
                answer[1] = 6;
            }
            return answer;
        }
    }
}
