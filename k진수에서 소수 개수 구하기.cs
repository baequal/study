using System;
using System.Collections.Generic;

namespace Codingstudy
{
    class Program
    {
        static void Main(string[] args)
        {
            int input1 = 437674;
            int input2 = 3;

            Program p = new Program();

            int output = p.solution(input1,input2);
            Console.WriteLine(output);
        }
          //n             k   result
         //437674	3	    3
         //110011	10	2
        public int solution(int n, int k)
        {
            int answer = 0;
            int x = n;
            int zerocnt = 0;
            int checkcnt = 0;
            int zeroindex = 0;

            string temp = "";

            while (x > 0)
            {
                temp = (x % k) + temp;
                x = x / k;
            }
            //1~4 
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == '0')
                {
                    zerocnt++;


                    if (zerocnt == 2)
                    {
                        checkcnt++;
                        if (i - zeroindex == 1)
                        {

                        }
                        else
                        {
                            long a = Convert.ToInt64(temp.Substring(zeroindex + 1, i - zeroindex - 1));
                            if (a == 2)
                            {
                                answer++;
                            }
                            else if (a == 1)
                            {

                            }
                            else
                            {
                                answer++;
                                for (long j = 2; j <= Math.Sqrt(a); j++)
                                {
                                    if (a % j == 0)
                                    {
                                        answer--;
                                        break;
                                    }
                                }
                            }
                        }
                        zerocnt = 1;
                    }
                    else if (zerocnt == 1 && checkcnt == 0 && i != 0)
                    {
                        checkcnt++;
                        long a = Convert.ToInt64(temp.Substring(0, i));
                        if (a == 2)
                        {
                            answer++;
                        }
                        else if (a == 1)
                        {

                        }
                        else
                        {
                            answer++;
                            for (long j = 2; j <= Math.Sqrt(a); j++)
                            {
                                if (a % j == 0)
                                {
                                    answer--;
                                    break;
                                }
                            }
                        }
                        zerocnt = 1;
                    }
                    zeroindex = i;

                }
                else if (i == temp.Length - 1 && zerocnt == 1)
                {
                    checkcnt++;
                    long a = Convert.ToInt64(temp.Substring(zeroindex + 1, i - zeroindex));
                    if (a == 2)
                    {
                        answer++;
                    }
                    else if (a == 1)
                    {

                    }
                    else
                    {
                        answer++;
                        for (long j = 2; j <= Math.Sqrt(a); j++)
                        {
                            if (a % j == 0)
                            {
                                answer--;
                                break;
                            }
                        }
                    }
                    zerocnt = 1;
                }
                else if (i == temp.Length - 1 && checkcnt == 0 && zerocnt == 0)
                {
                    long a = Convert.ToInt64(temp);
                    if (a == 2)
                    {
                        answer++;
                    }
                    else if (a == 1)
                    {

                    }
                    else
                    {
                        answer++;
                        for (long j = 2; j <= Math.Sqrt(a); j++)
                        {
                            if (a % j == 0)
                            {
                                answer--;
                                break;
                            }
                        }
                    }
                }
            }


            return answer;
        }
    }
}
