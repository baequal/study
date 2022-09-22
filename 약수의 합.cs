using System;
using System.Collections.Generic;

namespace Codingstudy
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 12;

            Program p = new Program();

            int output = p.solution(input);
            Console.WriteLine(output);
        }
        //in 12 out	28
        public int solution(int n)
        {
            int answer = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    answer += i;
                }
            }

            return answer;
        }
    }
}
