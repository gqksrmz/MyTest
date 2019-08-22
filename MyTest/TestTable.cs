//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Text;

//namespace MyTest
//{
//    class TestTable
//    {
//        static void Main(string[] args)
//        {
//            //创建一个临时数据库
//            DataSet ds = new DataSet();
//            //创建一个临时数据表
//            DataTable dt = new DataTable("Users");
//            //创建第一列id
//            DataColumn daAutoId = new DataColumn("autoId");
//            daAutoId.AutoIncrement = true;
//            daAutoId.AutoIncrementSeed = 1;
//            daAutoId.AutoIncrementStep = 1;

//            dt.Columns.Add(daAutoId);
//            dt.Columns[0].Unique = true;
//            //创建第二列用户名
//            dt.Columns.Add("loginid", typeof(string));
//            //创建第三列密码
//            dt.Columns.Add("loginpwd", typeof(string));
//            ds.Tables.Add(dt);
//            //新建添加行
//            for (int i = 0; i < 10; i++)
//            {
//                DataRow dr = dt.NewRow();
//                dr[1] = "root";
//                dr[2] = "123456";
//                dt.Rows.Add(dr);
//            }
//            foreach (DataTable dataTable in ds.Tables)
//            {
//                Console.WriteLine("表名{0}", dataTable.TableName);
//                foreach (DataRow dataRow in dataTable.Rows)
//                {
//                    for (int i = 0; i < dataTable.Columns.Count; i++)
//                    {
//                        Console.Write(dataRow[i].ToString() + " ");
//                    }
//                    Console.WriteLine();
//                }
//            }


//        }


//    }
//}
