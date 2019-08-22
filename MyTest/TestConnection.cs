//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Data.SqlClient;
//namespace MyTest
//{
//    class TestConnection
//    {
//        static void Main(string[] args)
//        {
//            string constr = "Data Source=DESKTOP-V4D9RI7;Initial Catalog=Test;User Id=sa;Password=123456";
//            using (SqlConnection con=new SqlConnection(constr))
//            {
//                string sql = string.Format("insert into Student values('{0}','{1}')", "李雷", 21);
//                using (SqlCommand cmd=new SqlCommand(sql, con))
//                {
//                    con.Open();
//                    int r = cmd.ExecuteNonQuery();
//                    Console.WriteLine("成功插入" + r + "行！");
                    
//                }
               
//            }
//            Console.ReadKey();
//            string connectionStr = string.Format("Data Source=DESKTOP-V4D9RI7;Initial Catalog=Test;User Id=sa;Password=123456");
//            using (SqlConnection con=new SqlConnection(connectionStr))
//            {
//                string sql = string.Format("select * from Student");
//                using (SqlCommand cmd=new SqlCommand(sql,con))
//                {
//                    con.Open();
//                    using (SqlDataReader reader=cmd.ExecuteReader())
//                    {
//                        if (reader.HasRows)
//                        {
//                            while (reader.Read())
//                            {
//                                Console.Write(reader.GetValue(0) + " ");
//                                Console.Write(reader.GetValue(1) + " ");
//                                Console.WriteLine(reader.GetValue(2) + " ");
//                            }
//                        }
//                    }
//                }
//            }
//        }
      
//    }
//}
