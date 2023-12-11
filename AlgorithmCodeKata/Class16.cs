using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata
{
    internal class Class16
    {
        public class Solution16
        {
            public long[] solution(int x, int n)
            {
                long[] answer = new long[n];

                for (int i = 1; i <= n; i++)
                {
                    answer[i - 1] = (long)x * i;
                    // answer[0] = (long)x
                    // answer[1] = (long)x*2
                }

                return answer;
            }//x수 만큼 x번 간격두기
        }
    }
}
