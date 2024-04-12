using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World?!");

            //요버플로우 연습
            int a = 2000000000;
            int b = 1000000000;
            Console.WriteLine(a + b);

            //오버플로우연습2
            Console.WriteLine((long)a + b);
            Console.WriteLine(a + (long)b);
            Console.WriteLine((long)a + (long)b);

            //자료형 최대 최소 값 출력하기
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            //sizeof 연산자 연습
            Console.WriteLine("int : " + sizeof(int));
            Console.WriteLine("long : " + sizeof(long));
            Console.WriteLine("float : " + sizeof(float));
            Console.WriteLine("double : " + sizeof(double));
            Console.WriteLine("char : " + sizeof(char));
            Console.WriteLine("bool : " + sizeof(bool));
        }
    }
}
