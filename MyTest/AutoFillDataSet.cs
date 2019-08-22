//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Text;

//namespace MyTest
//{
//    class AutoFillDataSet
//    {
//        static void Main(string[] args)
//        {
//            string str = "Data Source=DESKTOP-V4D9RI7;Initial Catalog=Test;User Id=sa;Password=123456";
//            string sql = "select * from Users";
//            SqlDataAdapter adapter = new SqlDataAdapter(sql, str);
//            DataTable dt = new DataTable();
//            adapter.Fill(dt);
//            Console.WriteLine("获取成功！");
//            foreach (DataRow item in dt.Rows)
//            {
//                for (int i = 0; i < dt.Columns.Count; i++)
//                {
//                    Console.Write(item[i].ToString() + " ");
//                }
//                Console.WriteLine();
//            }



//            for (int i = 0; i < dt.Rows.Count; i++)
//            {//对行循环
//                for (int j = 0; j < dt.Columns.Count; j++)
//                {//对列循环
//                    Console.Write(dt.Rows[i][j].ToString() + " ");//某单元格的值
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
