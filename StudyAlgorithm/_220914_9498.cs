using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _220914_9498
{
    //시험 점수를 입력받아 90 ~ 100점은 A, 80 ~ 89점은 B, 70 ~ 79점은 C, 60 ~ 69점은 D, 나머지 점수는 F를 출력하는 프로그램
    static void Main()
    {
        int score = int.Parse(Console.ReadLine());
        if (score >= 90) Console.WriteLine("A");
        else if (score >= 80) Console.WriteLine("B");
        else if (score >= 70) Console.WriteLine("C");
        else if (score >= 60) Console.WriteLine("D");
        else Console.WriteLine("F");
    }

}

