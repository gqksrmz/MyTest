using System;
using System.Collections.Generic;
using System.Text;

namespace MyTest
{
    public class TestHuiWen
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("请输入一个字符串：");
            string str = Console.ReadLine();
            char[] s1 = str.ToCharArray();
            char[] s2 = (char[])s1.Clone();
            
            Array.Reverse(s2);
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == s2[i])
                {
                    count++;
                }
            }
            if (count == str.Length)
            {
                Console.WriteLine("您输入的字符串是回文！");
            }
            else
            {
                Console.Write("您输入的字符串不是回文！");
            }
        }
    }
}
