//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.IO;
//using System.Text;

//namespace MyTest
//{
//    class TestInput
//    {
//        static void Main(string[] args)
//        {
//            string str = "Data Source=DESKTOP-V4D9RI7;Initial Catalog=Test;User Id=sa;Password=123456";
//            using (SqlConnection con = new SqlConnection(str))
//            {
//                string sql = "insert into Users values(@userid,@userpassword)";
//                using (SqlCommand cmd = new SqlCommand(sql, con))
//                {
//                    con.Open();
//                    SqlParameter p1 = new SqlParameter("@userid", SqlDbType.NVarChar);
//                    SqlParameter p2 = new SqlParameter("@userpassword", SqlDbType.NVarChar);
//                    cmd.Parameters.Add(p1);
//                    cmd.Parameters.Add(p2);
//                    using (StreamReader sr = new StreamReader(@"C:\Users\DELL\Desktop\output.txt"))
//                    {


//                        while (!sr.EndOfStream)
//                        {
//                            string line = sr.ReadLine();
//                            string[] columns = line.Split(',');
//                            p1.Value = columns[1];
//                            p2.Value = columns[2];
//                            cmd.ExecuteNonQuery();
//                            Console.WriteLine("插入成功!");
//                        }
//                    }
//                }
//            }
//        }
//    }
//}
