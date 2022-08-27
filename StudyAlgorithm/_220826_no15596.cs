using System;
using System.Collections.Generic;
using System.Linq;

class _220826_no15596
{   //백준 15596번 정수 N개의 합
    //목표: 람다와 형식 매개변수 T를 이용하기
    int Sum<T>(T n, T c, T sum);
    //문제 : 정수 n개가 주어졌을 때, n개의 합을 구하는 함수를 작성하시오.
    //합을 구해야 하는 정수 n개가 저장되어 있는 배열 (0 ≤ a[i] ≤ 1,000,000, 
    //합을 구해야 하는 정수의 개수  1 ≤ n ≤ 3,000,000)
    //리턴값: a에 포함되어 있는 정수 n개의 합

    static void Main()
    {
        //[1] INPUT :0 ≤ numbers[i] ≤ 1,000,000 데이터,
        //          1 ≤ n ≤ 3,000,000 합을 구해야하는 n개 정수
        var numbers = Enumerable.Range(0, 1_000_000).ToArray();
        int n = new numbers;
        //0~1,000,000 범위 안의 int를 가진 array 배열 numbers
        var count = Enumerable.Range(1, 3_000_000).ToArray();
        //1~3,000,000 범위 안의 int를 가진 array 배열 count

        //[2] PROGRESS :
        (int n, int c) =>for (int i = 0; i < c; i++)
        {//정수의 개수 만큼 반복한다
            int sum += n;//sum에 numbers를 대입
            
        }

        //[3] OUTPUT :
        Console.WriteLine($"정수 n개를 합한 값 : {sum}");
    }

}

