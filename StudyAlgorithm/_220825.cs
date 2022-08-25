using System;
using System.Collections.Generic;
using System.Linq;

class _220825
{
    //기초알고리즘 강의 수강 후 새로운 레포지토리에 응용 연습 시작
    //[?] 변수를 제시했을 때 x의 값 구하기
    
    static void Main()
    {
        int i=6; int j=8;
        if (i>0&&j>0)
        {
            j += i++;
        }
        Console.WriteLine($"i의 값 : {i}, j의 값 : {j}");
    }
}

