using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class _220907_no11720
{
    //[?] 공백없이 쓰여진 n개의 숫자를 합하여 출력
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        //공백없이 숫자를 받는다.
        //반복문으로 int인수에 앞숫자부터 뒷수자까지 +=한다.
        int sum = 0;
        for (int i = 0; i < x; i++)
        {
            sum += x;
        }
        Console.WriteLine($"총 합계 :{sum}");

    }
}

