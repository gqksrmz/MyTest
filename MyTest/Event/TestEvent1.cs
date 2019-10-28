using System;
using System.Collections.Generic;
using System.Text;

namespace MyTest.Event
{
    public class TestEvent1
    {

    }
    //类通常根据所含有的信息来命名,而不是根据所使用的事件
    //通常通过属性或者只读字段来暴露数据
    //为事件选择或者定义委托：
    //返回类型是void
    //接收两个参数，
    //第一个参数类型是object
    //第二个参数是EventArgs的子类。
    //第一个参数表示事件的广播者
    //第二个参数包含传递的信息
    //名称必须以EventHandler结尾
    //.NET Framework定义了一个泛型委托System.EventHandler<T>，它满足上述规则

    //可触发事件的protected virtual方法
    //方法名必须和事件一致，前面加上On，接受一个EventArgs参数
    public delegate void EventHandler<TEventArgs>
        (Object source, TEventArgs e) where TEventArgs : EventArgs; 
    public class PriceChangedEventArgs:System.EventArgs
    {
        public readonly decimal LastPrice;
        public readonly decimal NewPrice;
        public PriceChangedEventArgs(decimal lastPrice,decimal newPrice)
        {
            this.LastPrice = lastPrice;
            this.NewPrice = newPrice;
        }
    }
    public class Stock
    {
        public event EventHandler<PriceChangedEventArgs> PriceChanged;
        protected virtual void OnPriceChanged(PriceChangedEventArgs e)
        {
            if (PriceChanged != null)
            {
                PriceChanged(this, e);
            }
        }
    }
}
