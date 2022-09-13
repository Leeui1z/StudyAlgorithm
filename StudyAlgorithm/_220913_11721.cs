using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class _220913_11721
{
    //길이가 N 인 단어를 한 줄에 10글자씩 끊어서 출력
    //int.Parse(Console.ReadLine())로 숫자를 받는다.
    //다른 풀이에 while문으로 해결했는데 for로는 불가능한가?
    static void Main()
    {
        string str = Console.ReadLine();
        char[] num = str.ToCharArray();
        for (int i = 0; i < num.Length; i++)
        {
            Console.Write(num[i]);
            if (i % 10 ==9)
            {
                Console.WriteLine("");
            }
        }
    }

}

