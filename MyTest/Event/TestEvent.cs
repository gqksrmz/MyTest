using System;
using System.Collections.Generic;
using System.Text;

namespace MyTest
{
    //Delegate definition
    //public delegate void PriceChangedHandle(decimal oldPrice, decimal newPrice);
    public class TestEvent
    {
        //PriceChangedHandle priceChanged;
        //public event PriceChangedHandle PriceChanged
        //{
        //    add { priceChanged += value; }
        //    remove { priceChanged -= value; }
        //}
        //最简单的声明事件的方式就是在委托钱面加上event关键字
        //Event declaration
        //public event PriceChangedHandle priceChanged;

        //add和remove关键字代编着事件的访问器，有点像属性访问器
        //然后编译器会查看类内部对PriceChanged的引用
        //如果不是+=或者-=操作，那就直接把他们定向到底层的委托字段priceChanged
        //第三点,编译器把作用在event上的+=和-=操作翻译成调用add和remove访问器

        //为了编写事件，.NET定义了一个标准的模式
        //System.EventArgs,一个预定义的框架类,除了静态的Empty属性之外,它没有其他成员
        //EventArgs是为事件传递信息的类的基类
    }
}
