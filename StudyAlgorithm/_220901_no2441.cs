using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _220901_no2441
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        //첫째 줄에는 별 N개, 둘째 줄에는 별 N-1개, ..., N번째 줄에는 별 1개를 찍는 문제
        //하지만, 오른쪽을 기준으로 정렬한 별
        for (int i = 1; i < n; i++)//몇번째 줄인가
        {//첫줄에는 n개 둘째줄에는 " "1개, * n-1개, 셋쨰줄에는 " "2개, * n-2개...n번쨰 줄에는 별 1개
            for (int j = 1; j < i; j++)
            {
                Console.WriteLine(" ");
            }
            for (int j = 1; j < n-i; j++)
            {
                Console.WriteLine("*");
            }
            Console.WriteLine();
        }
    }
}

