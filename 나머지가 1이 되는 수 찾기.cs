using System;
using System.Collections.Generic;

namespace Codingstudy
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 10;

            Program p = new Program();

            int output = p.solution(input);
            Console.WriteLine(output);
        }
        //input 10 output 3
        public int solution(int n)
        {
            int answer = 0;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 1)
                {
                    answer = i;
                    break;
                }

            }

            return answer;
        }
    }
}
