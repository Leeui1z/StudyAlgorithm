using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class _220904_no1924
{
    //오늘은 2007.1.1 월요일이다. 그렇다면 x월 y일은 무슨 요일일까. 이에 대한 프로그램을 작성하시오.
    //input : 첫번쨰 줄에 빈칸을 사이에 두고 x(1~12)와 y(1~31)이 주어진다.
    //         1,3,5,7,8,10,12월은 31일, 4,6,9,11월은 30일, 2월은 28일까지.
    static void Main()
    {
        int day = 0;
        int[] monthArr = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        int x, y = int.Parse(Console.ReadLine());
        for (int i = 0; i <=12; i++)//....고민해볼것...다르게 하는 방법은 없을까....
        {
            day += monthArr[i];
        }
        day += y;
        day = day % 7;//day값을 7로 나눈 나머지 --7로 떨어지면 일요일, 이후는 월화수목금토일
        switch (day)
        {
            case 0: Console.WriteLine("일요일");break;
            case 1: Console.WriteLine("월요일"); break;
            case 2: Console.WriteLine("화요일"); break;
            case 3: Console.WriteLine("수요일"); break;
            case 4: Console.WriteLine("목요일"); break;
            case 5: Console.WriteLine("금요일"); break;
            case 6: Console.WriteLine("토요일"); break;
            default:break;

        }
    }
}
