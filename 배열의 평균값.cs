using System;
using System.Collections.Generic;

namespace Codingstudy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            Program p = new Program();

            double output = p.solution(input1);
            Console.WriteLine(output);
        }
        //numbers	                           result
        //[1, 2, 3, 4, 5, 6, 7, 8, 9, 10]	 5.5
        public double solution(int[] numbers)
        {
            double answer = 0;

            foreach (int i in numbers)
            {
                answer += i;
            }
            answer = answer / numbers.Length;

            return answer;
        }
    }
}
