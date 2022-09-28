using System;
using System.Collections.Generic;

namespace Codingstudy
{
    class Program
    {
        static void Main(string[] args)
        {
            int input1 = 3;
            long input2 = 2;
            long input3 = 5;

            Program p = new Program();

            int[] output = p.solution(input1,input2,input3);
            Console.WriteLine(output);
        }
        //n	left	right	result
        //3	2	5	[3,2,2,3]
        public int[] solution(int n, long left, long right)
        {
            int[] answer = new int[right - left + 1];
            //List<int> temp = new List<int>();
            long cnt = left - left % n;
            int index = 0;

            for (long i = left / n; i < n; i++)
            {
                for (long j = 0; j < n; j++)
                {
                    if (cnt > right)
                    {
                        break;
                    }
                    if (cnt >= left && cnt <= right)
                    {
                        answer[index] = Convert.ToInt32(Math.Max(i, j) + 1);
                        index++;
                    }
                    cnt++;
                }
                if (cnt > right)
                {
                    break;
                }
            }
            return answer;
        }
    }
}
