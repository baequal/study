using System;
using System.Collections.Generic;

namespace Codingstudy
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "CBD";
            string[] input2 = { "BACDE", "CBADF", "AECB", "BDA" };
            
            Program p = new Program();

            int output = p.solution(input1,input2);
            Console.WriteLine(output);
        }
        // skill     skill_trees	                                          return
        // "CBD"	["BACDE", "CBADF", "AECB", "BDA"] 	 2
        // 가능한 스킬트리 갯수.
        //skill 순서는 string skill 순서대로. 
        //"CBADF", "AECB" 가능
        public int solution(string skill, string[] skill_trees)
        {
            int answer = 0;
            int beforeindex = 0;
            int currentindex = 0;

            for (int i = 0; i < skill_trees.Length; i++)
            {
                for (int j = 0; j < skill.Length; j++)
                {
                    if (j == 0)
                    {
                        beforeindex = skill_trees[i].IndexOf(skill[j]);
                    }
                    else
                    {
                        currentindex = skill_trees[i].IndexOf(skill[j]);
                        if (currentindex >= 0 )
                        {
                            if (beforeindex == -1)
                            {
                                break;
                            }
                            else if (currentindex < beforeindex)
                            {
                                break;
                            }
                            
                        }
                        beforeindex = currentindex;
                    }
                    if (j == skill.Length - 1)
                    {
                        answer++;
                    }
                }
            }

            return answer;
        }
    }
}
