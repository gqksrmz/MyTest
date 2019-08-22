//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.IO;
//using System.Text;

//namespace MyTest
//{
//    class OutPutTest
//    {
//        static void Main(string[] args)
//        {
//            string conStr = "Data Source=DESKTOP-V4D9RI7;Initial Catalog=Test;User Id=sa;Password=123456;";
//            using (SqlConnection con = new SqlConnection(conStr))
//            {
//                string sql = "select * from Users;";
//                using (SqlCommand cmd = new SqlCommand(sql, con))
//                {
//                    con.Open();
//                    using (SqlDataReader reader = cmd.ExecuteReader())
//                    {
//                        if (reader.HasRows)
//                        {
//                            using (StreamWriter sw = new StreamWriter(@"C:\Users\DELL\Desktop\output.txt"))
//                            {
//                                while (reader.Read())
//                                {
//                                    object id = reader.GetValue(0);
//                                    object userId = reader.GetValue(1);
//                                    object userPwd = reader.IsDBNull(2) ? "NULL" : reader.GetValue(2);
//                                    string outputStr = string.Format("{0},{1},{2}", id, userId, userPwd);
//                                    sw.WriteLine(outputStr);
//                                    Console.WriteLine("输出成功!");
//                                }
//                            }

//                        }
//                    }
//                }
//            }
//        }
//    }
//}
