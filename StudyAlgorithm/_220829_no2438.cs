using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class _220829_no2438
{
    //첫째 줄에는 별1개, 둘째는 별2개, N번째 줄에는 별 N개를 찍는 문제
    static void Main()
    {
        //[1] Input : 1<N=<100
        int n = int.Parse(Console.ReadLine());
        //[2] progress : 
        for (int i = 1; i < n; i++)//n회 까지 반복
        {
            for (int j = 0; j < i; j++)//n회까지 반복하는 동안 n까지 숫자만큼 *찍는 반복문
            {
                Console.Write("*");
            }
            Console.WriteLine();
            //[3] Output :첫번째 줄부터 N번쨰 줄까지 차례대로 별을 출력한다.
        }

    }
}