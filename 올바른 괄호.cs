using System;
using System.Collections.Generic;

namespace Codingstudy
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "())()(()";

            Program p = new Program();

            bool output = p.solution(input1);
            Console.WriteLine(output);
        }
        //()()   열었으면 닫아야한다.
        public bool solution(string s)
        {
            bool answer = true;
            int count = 0;


            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0 && s[i] == ')')
                {
                    count--;
                    answer = false;
                    break;
                }
                else if (s[i] == '(')
                {
                    count++;
                }
                else if (s[i] == ')')
                {
                    count--;
                }
                if (count < 0)
                {
                    answer = false;
                    break;
                }
            }

            if (count == 0&&answer==true)
            { answer = true; }
            else
            {
                answer = false;
            }


            return answer;
        }
    }
}
