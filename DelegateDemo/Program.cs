using System;

namespace DelegateDemo
{
    //逆变只能输入，协变可以输出
    class Program
    {
       
        static void Main(string[] args)
        {
            int fac = 10;
            Func<int, int> tFunc = x => x * fac;
            Console.WriteLine(tFunc(5));


        }
    }

   
}
