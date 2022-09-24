using System;
using System.Collections.Generic;

namespace Codingstudy
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "AAAAE";
           
            Program p = new Program();

            int output = p.solution(input1);
            Console.WriteLine(output);
        }
        //"AAAAE"	6  word는 'A', 'E', 'I', 'O', 'U' 로만 구성됨. 길이 1~5
        public int solution(string word)
        {
            int answer = 0;
            string rule = "AEIOU";
            List<string> anslist = new List<string>();

            for (int i = 0; i < rule.Length; i++)
            {
                for (int j = 0; j <= rule.Length; j++)
                {
                    for (int k = 0; k <= rule.Length; k++)
                    {
                        for (int l = 0; l <= rule.Length; l++)
                        {
                            for (int m = 0; m <= rule.Length; m++)
                            {
                                string temp = "";
                                temp += rule[i];
                                if (j != rule.Length)
                                {
                                    temp += rule[j];
                                }
                                if (k != rule.Length)
                                {
                                    temp += rule[k];
                                }
                                if (l != rule.Length)
                                {
                                    temp += rule[l];
                                }
                                if (m != rule.Length)
                                {
                                    temp += rule[m];
                                }
                                if(anslist.IndexOf(temp)==-1)
                                {
                                    anslist.Add(temp);
                                }
                                
                            }
                        }
                    }
                }
            }

            anslist.Sort();
            answer = anslist.IndexOf(word)+1;

            return answer;

        }
    }
}
