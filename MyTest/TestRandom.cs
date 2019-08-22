//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Text;

//namespace MyTest
//{
//    class TestRandom
//    {
//        static void Main(string[] args)
//        {
//            int[] nums = new int[200];
//            Random random = new Random();
//            for (int i = 0; i < nums.Length; i++)
//            {
//                nums[i] = random.Next(0, 100);
//            }
//            Hashtable ht = new Hashtable();
//            for (int i = 0; i < nums.Length; i++)
//            {
//                if (ht.ContainsKey(nums[i]))
//                {
//                    int n = (int)ht[nums[i]];
//                    n++;
//                    ht[nums[i]] = n;
//                }
//                else
//                {
//                    ht.Add(nums[i], 1);
//                }
//            }
//            ArrayList al = new ArrayList(ht.Keys);
//            al.Sort();
//            foreach (var item in al)
//            {
//                int d = (int)ht[item];
//                double dd = d / 200.0;
//                Console.WriteLine("键是{0}，值是{1},频率是{2:0.00%}", item, ht[item], dd);
//            }
//        }
//    }
//}
