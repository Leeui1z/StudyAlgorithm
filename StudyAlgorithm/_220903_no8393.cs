using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class _220903_no8393
{
    static void Main()
    {
        //n이 주어졌을 때, 1부터 n까지 합을 구하는 프로그램 작성하라
        int n = int.Parse(Console.ReadLine());//n이 주어졌을 때.
        int sum = 0;
        for (int i = 1; i < n; i++)
        {
            sum += i;
        }
        Console.WriteLine($"1부터 {n}까지의 합: {sum}");

    }
}

