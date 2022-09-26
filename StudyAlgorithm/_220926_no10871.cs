using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class _220926_no10871
    {
        //정수 N개로 이루어진 수열 A와 정수 X가 주어진다. 이때, A에서 X보다 작은 수를 모두 출력한는 프로그램을 작성하시오
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int A = int.Parse(Console.ReadLine());
                if (A < x) Console.WriteLine(A + "");
            }
        }//답 보고 작성은 했는데 이해가 잘 안간다....
    }
