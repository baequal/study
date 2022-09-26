using System;
using System.Collections.Generic;

namespace Codingstudy
{
    class Program
    {
        static void Main(string[] args)
        {
            long input1 = 4;

            Program p = new Program();

            long output = p.solution(input1);
            Console.WriteLine(output);
        }
        //5->8
        //4->5
        //3->3
        //피보나치
        public long solution(long n)
        {
            long answer = 0;

            long[] temp = new long[n + 1];
            temp[0] = 1;
            temp[1] = 1;
            if (n < 2)
            {
                answer = 1;
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    temp[i] = temp[i - 1] % 1234567 + temp[i - 2] % 1234567;
                }
                answer = temp[n] % 1234567;
            }
            return answer;
        }
    }
}
