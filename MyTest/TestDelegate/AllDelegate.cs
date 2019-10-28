using System;
using System.Collections.Generic;
using System.Text;

namespace MyTest.TestDelegate
{
    public class AllDelegate
    {

        //Func和Action都在System命名空间下
        //delegate TResult Func<out TResult>();
        //delegate TResult Func<in T, out TResult>(T args);
        //delegate TResult Func<in T1, in T2, out TResultl>(T1 args, T2 arg2);
        //Func最多可以16个参数,是有返回类型的委托

        //delegate void Action();
        //delegate void Action(in T)(T args);
        //delegate void Action<in T1, in T2>(T1 arg1, T2 arg2); 
        //Action返回类型为void 没有返回类型，可以没有参数，也可以最多有16个参数，只能输入，是逆变
        //In 关键字：逆变，代表输入，代表着只能被使用，不能作为返回值

        //接口vs委托
        //委托可以解决的问题，接口都可以解决
        //什么情况下更适合使用委托而不是接口呢？当下列条件之一满足时：
        //1.接口只能定义一个方法
        //2.需要多播能力
        //3.订阅者需要多次实现接口
        //委托类型之间互不相容，即使方法签名(方法名和参数列表)相同
        //如果委托示例拥有相同的目标方法，那么委托实例就被认为是相等的
        //当你调用一个方法时，你提供的参数可以比方法的参数定义更具体
        //委托可以接受比他的方法参数跟具体的参数类型，这个叫ContraVariance(逆变)。
        //和泛型类型参数一样，委托的ContraVariance仅支持引用转换
        //在调用方法时，你可以得到一个比请求的类型更具体的类型的返回结果。
        //委托的目标方法可以返回比委托描述里更具体的类型的返沪结果，Covariance(协变)
        //反省委托类型参数的Variance
        //Covariance,out 协变
        //ContraVariance,in 逆变 
    }
}
