using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Progress
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> strings = new List<string> { "a", "b", "c" };
            IEnumerable<object> objects = strings;
            //variance只能出现在接口和委托里
            //Convariance协变，当值作为返回值/out输出
            //Contravariance逆变，当值作为输入input
            //Invariance不变，当值既是输入又是输出
            //public interface IEnumberable<out T>
            //public delegate void Action<in T>
            //public interface IList<T>
            IEnumerable<string> strings1 = new[] { "a", "b", "cdefg", "hij" };
            List<Object> list = strings1
                .Where(x => x.Length > 1)
                .Cast<object>()
                .ToList();//ToList(Object)
        }
    }
}
