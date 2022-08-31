using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class _220831_no2440
{
    //첫째 줄에는 별n개, 둘째는 별n-1개, N번째 줄에는 별 1개를 찍는 문제
    static void Main()
    {
        //[1] Input : 1<N=<100
        int n = int.Parse(Console.ReadLine());
        //[2] progress
        for (int i = 1; i <= n; i++)//몇번째 줄인가
        {
            for (int j = 1; j <= n-i+1; j++)//별의 개수
            {//1일떄 n개, 2일때 n-1개...i일 때 n-i+1개

                Console.WriteLine("*");
            }
            Console.WriteLine();
        }
    }
}

