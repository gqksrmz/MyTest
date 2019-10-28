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
            //Convariance协变，当值作为返回值/out输出
            //Contravariance逆变，当值作为输入input
            //Invariance不变，当值既是输入又是输出
            //public interface IEnumberable<out T>
            //public delegate void Action<in T>
            //public interface IList<T>
        }
    }
}
