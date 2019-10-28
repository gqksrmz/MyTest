//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MyTest
//{
//    public class TestLambda
//    {
//        static void Foo<T>(T x) { }
//        static void Bar<T>(Action<T> a) { }
//        static void Main(string[] args)
//        {
//            int add(int x,int y)
//            {
//                return x + y;
//            }
//            int re = add(50, 50);
//            Console.WriteLine($"结果是{re}");
//            参数类型int 返回值int
//            Func<int, int> sqr = x => x * x;
//            参数类型string 返回值int 最后的是返回值
//            Func<string, string,int> totalLength = (s1, s2) => s1.Length + s2.Length;
//            int result = sqr(5);
//            int total = totalLength("Hello", "World");
//            Console.WriteLine(result);
//            Console.WriteLine(total);

//            Bar(x => Foo(x));//错误，未指定类型
//            Bar((int x) => Foo(x));
//            Bar<int>(x => Foo(x));
//            Bar<int>(Foo);

//            捕获外部变量
//            被lambda表达式引用的外部变量叫做被捕获的变量(captured variables)
//            捕获了外部变量的lambda表达式叫做闭包(closure)
//            被捕获的变量实在委托被实际调用的时候才被计算，而不是在被捕获的时候
//            int factor = 2;
//            Func<int, int> multiplier = n => n * factor;
//            factor = 10;
//            Console.WriteLine(multiplier(3));
//            Console.WriteLine();
//            Lambda表达式本身也可以更新被捕获的变量
//            int seed = 0;
//            Func<int> natural = () => seed++;
//            Console.WriteLine(natural());//先返回0再对seed进行++
//            Console.WriteLine(natural());
//            Console.WriteLine(natural());
//            Console.WriteLine(seed);
//            Console.WriteLine();
//            被捕获的变量的生命周期会被延长到和委托一样
//            Func<int> na = Natural();
//            Console.WriteLine(na());
//            Console.WriteLine(na());
//            Console.WriteLine();
//            在Lambda表达式内实例化的本地变量对于委托实例的每次调用来说都是唯一的
//            Func<int> addFunc = Add();
//            Console.WriteLine(addFunc());
//            Console.WriteLine(addFunc());
//            Console.WriteLine();
//            捕获迭代变量
//            当捕获for循环的迭代变量时
//            c#会把这个变量当作是在循环外部定义的变量
//            这就意味着每次迭代捕获的都死同一个变量

//            Action[] actions = new Action[3];
//            for (int i = 0; i < actions.Length; i++)
//            {
//                actions[i]=()=>Console.WriteLine(i);
//            }
//            foreach (Action action in actions)
//            {
//                action();
//            }
//            Console.WriteLine();
//            foreach
//            Action[] acs = new Action[3];
//            int j = 0;
//            foreach (char c in "abc")
//            {
//                acs[j++] = () => Console.WriteLine(c);
//            }
//            foreach (Action a in acs)
//            {
//                a();
//            }
//        }
//        static Func<int> Natural()
//        {
//            int seed = 0;
//            return () => seed++;
//        }
//        static Func<int> Add()
//        {
//            return () => { int seed = 0; return seed++; };
//        }
//    }
//}
