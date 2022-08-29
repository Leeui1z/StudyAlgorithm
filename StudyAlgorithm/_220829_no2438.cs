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
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        
        //[3] Output :첫번째 줄부터 N번쨰 줄까지 차례대로 별을 출력한다.

    }
}