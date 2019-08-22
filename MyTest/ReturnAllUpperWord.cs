//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MyTest
//{
//    public class ReturnAllUpperWord
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("请输入一个数字:");
//            string str = Console.ReadLine();
//            string newStr = Num2Char(str);
//            Console.WriteLine(newStr);
//        }
//        /// <summary>
//        /// 将数字转换成大写人民币
//        /// </summary>
//        /// <param name="v">要转换的数字字符串</param>
//        /// <returns>转换后的大写人民币字符串</returns>
//        private static string Num2Char(string var)
//        {
//            string retval = "";
//            bool IsPoint = false;
//            double v = double.Parse(var);
//            if (v > 0)
//            {
//                char[] chars = v.ToString().ToCharArray();
//                foreach (char c in chars)
//                {
//                    IsPoint = false;
//                    switch (c)
//                    {
//                        case '1': retval += "壹"; break;
//                        case '2': retval += "贰"; break;
//                        case '3': retval += "叁"; break;
//                        case '4': retval += "肆"; break;
//                        case '5': retval += "伍"; break;
//                        case '6': retval += "陆"; break;
//                        case '7': retval += "柒"; break;
//                        case '8': retval += "捌"; break;
//                        case '9': retval += "玖"; break;
//                        case '0': retval += "零"; break;
//                        default: IsPoint = true; break;
//                    }
//                    if (!IsPoint)
//                    {
//                        v = v / 10;
//                        if (v > 0.001 && v < 0.009999999999)
//                        {
//                            retval += "分";
//                        }
//                        else if (v > 0.01 && v < 0.099999999999)
//                        {
//                            retval += "角";
//                        }
//                        else if (v > 0.1 && v < 0.999999999999)
//                        {
//                            retval += "元";
//                        }
//                        else if (v > 1 && v < 9.999999999999)
//                        {
//                            retval += "拾";
//                        }
//                        else if (v > 10 && v < 99.999999999999)
//                        {
//                            retval += "佰";
//                        }
//                        else if (v > 100 && v < 999.999999999999)
//                        {
//                            retval += "仟";
//                        }
//                        else if (v > 1000 && v < 9999.999999999999)
//                        {
//                            retval += "万";
//                        }
//                        else if (v > 10000 && v < 99999.999999999999)
//                        {
//                            retval += "拾";
//                        }
//                        else if (v > 100000 && v < 999999.999999999999)
//                        {
//                            retval += "佰";
//                        }
//                        else if (v > 1000000 && v < 9999999.999999999999)
//                        {
//                            retval += "仟";
//                        }
//                        else if (v > 10000000 && v < 99999999.999999999999)
//                        {
//                            retval += "亿";
//                        }
//                    }
//                }
//            }
//            else
//            {
//                retval = "零";
//            }
//            return retval;
//        }


//    }

//}
